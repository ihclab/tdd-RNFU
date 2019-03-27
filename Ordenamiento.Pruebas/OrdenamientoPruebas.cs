using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.Pruebas
{
    [TestClass]
    public class PruebasOrdenamiento
    {
        private int[] salidaEsperada = new int[] {1,2,3,4,5};
        private Ordenamiento.Burbuja ordenar = new Ordenamiento.Burbuja();
        [TestMethod]
        public void PruebaOrdenado() {
            int[] entrada = new int[]{1,2,3,4,5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
        [TestMethod]
         public void PruebaMixed(){
            int[] entrada = new int[]{1,3,2,4,5};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
        [TestMethod]
        public void Pruebafinal(){
            int[] entrada = new int[]{5,1,2,3,4};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
        [TestMethod]
        public void PruebaSwap(){
            int[] entrada = new int[]{2,3,4,5,1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
        [TestMethod]
        public void PruebaInvertido(){
            int[] entrada = new int[]{5,4,3,2,1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
    }
}
