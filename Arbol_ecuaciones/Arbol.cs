using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_ecuaciones
{
    class Arbol
    {
        private Nodo inicio, final, raiz, inicioPila,finalPila,nPila;
       
        public void agregarLista(Nodo Nchar)
        {
            if (inicio == null)
                inicio = Nchar;
            else
                agregar(Nchar, inicio);
        }

        private void agregar(Nodo Nchar, Nodo ultimo)
        {
            if (ultimo.LSig == null)
            {
                ultimo.LSig = Nchar;
                Nchar.LAnt = ultimo;
                final = Nchar;
            }
            else
                agregar(Nchar, ultimo.LSig);
        }

        
        private void push (Nodo nChar)
        {
            if (inicioPila == null)
                inicioPila = nChar;
            else
                agregarAPila(nChar, inicioPila);
        }

        private void agregarAPila(Nodo nChar, Nodo ultimo)
        {
            if (ultimo.LSig == null)
            {
                ultimo.LSig = nChar;
                nChar.LAnt = ultimo;
                finalPila = nChar;
            }
            else
                agregarAPila(nChar, ultimo.LSig);
        }

        private string pop ()
        {
            string num;
            num = Convert.ToString(finalPila.condicion);
            finalPila = finalPila.LAnt;
            if (finalPila != null)
                finalPila.LSig = null;
            return num;
        }

        public void crearArbol ()
        {
            raiz = null;
            string charEv;

            Nodo cA = inicio, cAn = null, cSig = null;
            while (cA != null) //
            {
                cSig = cA.LSig;
                charEv = Convert.ToString(cA.condicion);
                if (charEv == "*" || charEv == "/")
                {
                    raiz = cA;
                    cA.AIzq = cA.LAnt; cA.ADrc = cA.LSig;
                    eliminarNodos(cA, cAn, cSig); 
                }             
                cAn = cA; cA = cA.LSig;
            }

            cA = inicio; cAn = null; cSig = null;
            while (cA != null) 
            {
                cSig = cA.LSig;
                charEv = Convert.ToString(cA.condicion);
                if (charEv == "+" || charEv == "-")
                {
                    raiz = cA;
                    cA.AIzq = cA.LAnt; cA.ADrc = cA.LSig;
                    eliminarNodos(cA, cAn, cSig);
                }               
                cAn = cA; cA = cA.LSig; 
            }
            inicio = null;
        }
        
        // elimina nodos ya enlazados al arbol
        private void eliminarNodos (Nodo cA, Nodo cAn, Nodo cSig)
        {
            if (cA.LAnt == inicio) // en caso de que el dato a eliminar sea el primero
            {
                inicio = inicio.LSig;
                inicio.LAnt = null;
            }
            else// en caso de no ser el primero
            {
                cA.LAnt = cAn.LAnt;
                cAn.LAnt.LSig = cA;
            } 

            if (cA.LSig == final)// en caso de eliminar el del final
            {
                final.LAnt.LSig = null;
                final = final.LAnt;
            }
            else // en caso de no ser el ultimo
            {
                cA.LSig = cSig.LSig;
                cSig.LSig.LAnt= cA;
            }
        }

        // lista Post-Order del arbol
        public string PostOrden()
        {
            if (raiz == null)
                return "Raiz vacia";
            else
                return PostOrder(raiz);
        }

        private string PostOrder(Nodo r)
        {
            string lista = "";

            if (r.AIzq != null)
                lista += PostOrder(r.AIzq); // I

            if (r.ADrc != null)
                lista += PostOrder(r.ADrc);// D

            lista += r.ToString();// R

            return lista;
        }

        // resuelve la notacion de la lista Post-Orden
        public string notacionPost()
        {
            int aP = 0;
            string res = ""; Nodo cA = inicio;

            while (cA != null) //recorre la lista para buscar numeros o expreciones
            {
                if (Char.IsNumber(Convert.ToChar(cA.condicion))== true)
                {
                    nPila = new Nodo(cA.condicion);
                    push(nPila);
                }
                else
                {
                    string cond = cA.ToString(), condC;
                        //segunda posicion           //primera posicion
                    int n1 = Convert.ToInt32(pop()), n2 = Convert.ToInt32(pop()); 
                    switch (cond)
                    {
                        case "+":
                            aP = n2 + n1;
                            break;
                        case "-":
                            aP = n2 - n1;
                            break;
                        case "*":
                            aP = n2 * n1;
                            break;
                        case "/":
                            aP = n2 / n1;
                            break;                            
                    }
                    condC = Convert.ToString(aP);
                    nPila = new Nodo(condC);
                    push(nPila);                    
                }
                cA = cA.LSig;
                if (cA == null)
                    res = Convert.ToString(pop());
            }
            inicioPila = null; finalPila = null; inicio = null;
            return res;
        }

        // resuelve la notacion de la lista Pre-Orden
        public string notacionPre()
        {
            int aP = 0;
            string res = ""; Nodo cA = final;

            while (cA != null) //recorre la lista para buscar numeros o expreciones
            {
                if (Char.IsNumber(Convert.ToChar(cA.condicion)) == true)
                {
                    nPila = new Nodo(cA.condicion);
                    push(nPila);
                }
                else
                {
                    string cond = cA.ToString(), condC;
                    //primera posicion           //segunda posicion
                    int n1 = Convert.ToInt32(pop()), n2 = Convert.ToInt32(pop());
                    switch (cond)
                    {
                        case "+":
                            aP = n1 + n2;
                            break;
                        case "-":
                            aP = n1 - n2;
                            break;
                        case "*":
                            aP = n1 * n2;
                            break;
                        case "/":
                            aP = n1 / n2;
                            break;
                    }
                    condC = Convert.ToString(aP);
                    nPila = new Nodo(condC);
                    push(nPila);
                }
                cA = cA.LAnt;
                if (cA == null)
                    res = Convert.ToString(pop());
            }
            inicioPila = null; finalPila = null; inicio = null;
            return res;
        }

        /// Lista Pre-Orden
        public string PreOrden()
        {
            if (raiz == null)
                return "Raiz vacia";
            else
                return PreOrder(raiz);
        }

        private string PreOrder(Nodo r)
        {
            string lista = "";

            lista += r.ToString();// R

            if (r.AIzq != null)
                lista += PreOrder(r.AIzq); // I

            if (r.ADrc != null)
                lista += PreOrder(r.ADrc);// D

            return lista;
        }










        public string reporte()
        {
            string infoLista = "";

            Nodo datoActual = inicioPila;
            while (datoActual != null) //recorre la lista
            {
                infoLista += datoActual.ToString();
                datoActual = datoActual.LSig;
            }

            return infoLista;
        }

        public string raizz() { return raiz.ToString(); }


    }
}
