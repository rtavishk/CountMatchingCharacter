using System;


namespace countMatchElement
{
    public class characterCount
    {

        public void test_String(String input_data)
        {
            input_data = input_data.Trim();
            input_data = input_data.ToLower();
            input_data = input_data.Replace(" ", "");


            char[] token = input_data.ToCharArray();
            
            for (int i = 0; i < token.Length; i++)
            {

                if (token[i] != '0')
                {
                    char the_character = token[i];
                    int count = 0;

                    for (int j = 0; j < input_data.Length; j++)
                    {
                        char test_character = token[j];
                        if (test_character != '0')
                        {
                            if (the_character == test_character)
                            {
                                count++;
                                token[j] = '0';
                            }
                        }

                    }
                    Console.WriteLine(the_character + " = " + count);
                }

                
            }



        }


        public static void Main (String [] args)
        {
            characterCount cc = new characterCount();
            cc.test_String("a spider man www aaa rr");
        }

    }
}