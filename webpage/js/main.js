//Custom messages on certain actions to look if the action works in the console.
//Easier for the coders to see if everything works.
function Debug(Message)
{

	var Message;
	var currentPage = top.location.href;

	switch(Message)
	{
		case 1:
			Message = "Button succesfully clicked.";
			console.log(Message);
			break;
		case 2:
			Message = "Opening page " + currentPage + ".";
			console.log(Message);
			break;
		case 3:
			Message = "";
			console.log(Message);
			break;
		case 4:
			Message = "";
			console.log(Message);
			break;

		default: Message = "Default message...";
			console.log(Message);
	}

}