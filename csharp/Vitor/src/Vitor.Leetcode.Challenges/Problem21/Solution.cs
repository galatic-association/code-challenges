namespace Vitor.Leetcode.Challenges.Problem21
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {            
            ListNode head = null;
            ListNode headAux = null;

            while (l1 != null || l2 != null)
            {                
                //Initialization part
                if (head is null)
                {
                    if (l1 != null)
                    {
                        head = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    if (l2 != null)
                    {
                        if (head != null)
                        {
                            if(head.val >= l2.val)
                            {   
                                var lastValue = head.val;
                                head.val = l2.val;
                                head.next = new ListNode(lastValue);
                            }
                            else
                                head.next = new ListNode(l2.val);                            
                        }
                        else
                            head = new ListNode(l2.val);

                        l2 = l2.next;
                    }
                    
                    if (head.next == null)
                        headAux = head;
                    else
                        headAux = head.next;
                }
                else
                {   
                    //aux will never be null;
                    var aux = l1;
                    if(aux == null || (l2 != null && aux.val > l2.val))
                        aux = l2;
                                           
                    if (headAux.val > aux.val)
                    {
                        var lastValue = headAux.val;
                        headAux.val = aux.val;
                        headAux.next = new ListNode(lastValue);
                    }
                    else
                        headAux.next = new ListNode(aux.val);

                    headAux = headAux.next;

                    //l1 and l2 will never be both null inside the loop
                    if(aux == l1 && l1 != null)
                        l1 = l1.next;
                    else
                        l2 = l2.next;
                }
            }

            return head;
        }
    }
}