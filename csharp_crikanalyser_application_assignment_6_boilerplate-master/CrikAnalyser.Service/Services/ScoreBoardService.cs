using CrikAnalyser.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrikAnalyser.Service.Services
{
    /*
     * This class uses delegate to call methods to perform runs and wickets Analysis
     * 
     * The analysis result would be of type structure
     * 
     */


    /*
     * declare delegate named ScoreBoardAnalyser for void methods taking no parameters
     * 
     */

    public struct Summary
    {
        /*
         * 
         * declare members to record summary values
         * 
         */
    }

    public class ScoreBoardService
    {
        /*
         * 
         * declare fields for runs and wickets summary
         * 
         */


        /* 
         * 
         * define method that returns multicast delegate named ScoreBoardAnalyser
         * this delegate is initiated with methods to be called
         * the paramters of the method are boolean to indicate which method should be invoked through delegate
         * 
         */


        /* 
         * 
         * define method to calculate summarized results for runs scored
         * 
         */


        /* 
         * 
         * define method to calculate summarized results for wickets taken
         * 
         */

    }
}
