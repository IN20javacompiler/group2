﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    public class Method : Node
    {
        public string modifier, name;
        public Type type;
        public VariableDeclarationStatement stmt;
        public Parameter parameters;
        public CompoundStatement body;

        public Method(Type type, String name)
        {
            // this.modifier = modifiers;
            this.type = type;
            this.name = name;
        }

        public Method(Type type, String name, Parameter parameter)

        {
            //this.modifier = modifiers;
            this.type = type;
            this.name = name;
              this.parameters = parameters;
            this.body = body;
        }
        public Method(Type type, String name, CompoundStatement body)
       

        {
            //this.modifier = modifiers;
            this.type = type;
            this.name = name;
            // this.parameters = parameters;
            this.body = body;
        }

        public override void dump(int indent)
        {

            type.dump(indent);
            label(indent, "Method Declaration :{0}\n", name);
            // parameters.dump(indent);
            label(indent + 1, "MethodBody\n");
            body.dump(indent);

        }

    }
      public class MethodInvocation : Method
     public class MethodInvocation : Expression
    {
        // private string name;
        
  
        /* public MethodInvocation(string name)
         {
             this.name = name;
          }*/
        public MethodInvocation()
        VariableDeclaratorId name;
        List<Expression> args;
        public MethodInvocation(VariableDeclaratorId name)
        {

           this.name = name;
        }        
 
        public MethodInvocation(VariableDeclaratorId name, List<Expression> args)
        {

            this.name = name;
            this.args = args;
          }
    public override void dump(int indent)
    {
        label(indent, "MethodInvocation \n");
    }
  
    }; 
    };
} 
