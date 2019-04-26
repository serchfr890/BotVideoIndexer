using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.AI.Luis;
namespace TextFlowDialog.Dialogs
{
    public class RootDialog
    {


        public static async Task MainDialog(ITurnContext turnContext)
        {
            await turnContext.SendActivityAsync("Hola Te estoy mandando este mensaje desde mainDialog");
        }

       
    }
}
