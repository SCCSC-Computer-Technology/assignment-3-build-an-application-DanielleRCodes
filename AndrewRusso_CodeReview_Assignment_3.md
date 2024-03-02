This is a lot. Its very well made, lots of images, but the gui is still easy to understand and navigate. Sadly I get error messages when attempting to look at the design view, but that is likely an issue on my end. I liked what you did with the photos, I thought to do something similar.

I wonder if placing the names of the states into an array bu pulling that information from your table and then using that index number might help you consolidate the long switch-case you have in the FormStateInfo.cs. I know you can get the index from a drop down and you can populate that from the table. maybe a method that passes in the index and then calls the shape, flag and flower/bird by referencing that index? might help you remove about 140 lines of code? I think this might have helped with you FillByStateNAme2 method as well, but I'm not sure what the end goal for it was, looks like it might have just been something you were doing to test some things.

I did have an issue where the info wouldn't fill in the FormStateInfo. The state shape, flower/bird and flag images all loaded but none of the text boxes did. I did see the table with your data and i loved the way you had that laid out. It was again, easy to understand and use. We wont always know the skill level of our end users and making things as simple as possible to use and understand is very important.

Being able to organize the states in groups by first letter of the state name was a neat trick and a good idea. Things like this help increase the form's usability. I wonder if there might have been a way to do this with an if/else if/else chain. I tried to make this into an if/else if/else but all I ended up coming up with was a super long if statment filled with ||s. The switch is probably a much more comfortable way to do it especially if you try something a bit more like this:

case 'a': case 'b': case 'c': case 'd': case 'e':
	c.Visible = false; break;

or 
                switch (firstChar)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    default: 
                        c.Visible = false; break;
                }

Ultimately it only saves a few lines and a little bit of copy and paste in this code, but maybe it'll be helpful later on.