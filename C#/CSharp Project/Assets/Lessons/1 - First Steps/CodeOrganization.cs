using UnityEngine;

//Namespaces for packages of certain types of codes or organizations
namespace Lesson01
{
    //SOLID principle: one script doing one thing, without multiple functions
    public class CodeOrganization : MonoBehaviour
    {
        private int intVariable = default;
        //Clean method names, if calculating the division, will be called CalculateDivision
        /// <summary>
        /// Method Summary
        /// </summary>
        private void Method()
        {
            //Method Content
        }
        /// <summary>
        /// Public Method Summary
        /// </summary>
        /// <param name="variable description"></param>
        public void PublicMethod(int variable)
        {
            /*
             * Method Content
             */
        }
    }
}