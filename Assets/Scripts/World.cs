using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

using Assets.Scripts.Modules;

public class World : MonoBehaviour {

    List<Node> listNode;
    List<Edge> listEdge;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void readListNode(string dir)
    {
        try
        {
            using (StreamReader sr = new StreamReader(dir))
            {
                string line;
                string[] var;
                Node node;

                while((line = sr.ReadLine()) != null)
                {
                    var = line.Split('\t');
                    if (var.Length != 6)
                        throw new Exception("wrong node file format");
                    node = new Node(
                        float.Parse(var[0]),
                        float.Parse(var[1]),
                        float.Parse(var[2]),
                        (int)Math.Round(float.Parse(var[3])),
                        float.Parse(var[4]),
                        var[5]);
                    listNode.Add(node);
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void readListEdge(string dir)
    {
        try
        {
            using (StreamReader sr = new StreamReader(dir))
            {
                string line;
                string[] var;
                Edge edge;
                int nNode = listNode.Count;
                int i = -1;
                int j;

                if (nNode == 0)
                    throw new Exception("empty listNode");
                while ((line = sr.ReadLine()) != null || i == nNode - 2)
                {
                    i += 1;
                    var = line.Split(' ');
                    if (var.Length != nNode)
                        throw new Exception("wrong node file format");
                    for(j = i+1; j<=nNode-1; j++)
                    {
                        edge = new Edge(listNode[i], listNode[j], float.Parse(var[j]));
                        listEdge.Add(edge);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }

}
