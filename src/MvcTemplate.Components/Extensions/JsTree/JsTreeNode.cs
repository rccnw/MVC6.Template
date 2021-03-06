﻿using System;
using System.Collections.Generic;

namespace MvcTemplate.Components.Extensions
{
    public class JsTreeNode
    {
        public Int32? Id { get; set; }
        public String Title { get; set; }
        public List<JsTreeNode> Nodes { get; set; }

        public JsTreeNode(Int32? id, String title)
        {
            Id = id;
            Title = title;
            Nodes = new List<JsTreeNode>();
        }
        public JsTreeNode(String title)
            : this(null, title)
        {
        }
    }
}
