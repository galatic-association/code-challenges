using System.Collections.Generic;
using Xunit;

namespace Vitor.Leetcode.Challenges.Problem21.Tests
{
    public class SolutionTests
    {
        [Theory]
        [MemberData(nameof(Parameters))]
        public void Should_Merge_Two_Linked_Lists_In_Order(ListNode firstList, ListNode secondsList, ListNode expectedList)
        {
            var sut = new Solution();
            var resultList = sut.MergeTwoLists(firstList, secondsList);
            AssertListNodeEqual(expectedList, resultList);
        }

        private void AssertListNodeEqual(ListNode expected, ListNode actual)
        {
            var expectedNode = expected;
            var actualNode = actual;

            while (expectedNode != null && actualNode != null)
            {
                Assert.Equal(expectedNode.val, actualNode.val);
                expectedNode = expectedNode.next;
                actualNode = actualNode.next;
            }

            Assert.True(expectedNode == null && actualNode == null, "Linked lists have different lengths");
        }

        public static IEnumerable<object[]> Parameters()
        {
            yield return new object[] {
                new ListNode(-2, new ListNode(5)),
                new ListNode(-9,new ListNode(-6,new ListNode(-3, new ListNode(-1, new ListNode(1, new ListNode(6)))))),
                new ListNode(-9,new ListNode(-6,new ListNode(-3, new ListNode(-2, new ListNode(-1, new ListNode(1, new ListNode(5, new ListNode(6)))))))),
            };

            yield return new object[] {
                new ListNode(-9, new ListNode(3)),
                new ListNode(5,new ListNode(7)),
                new ListNode(-9,new ListNode(3,new ListNode(5, new ListNode(7))))
            };

            yield return new object[] {
                new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4))),
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))))
            };

            yield return new object[] {
                null,
                new ListNode(0),
                new ListNode(0),
            };

            yield return new object[] {
                new ListNode(1),
                null,
                new ListNode(1),
            };

            yield return new object[] {
                new ListNode(2),
                new ListNode(1),
                new ListNode(1, new ListNode(2)),
            };

            yield return new object[] {
                new ListNode(5),
                new ListNode(1,new ListNode(2,new ListNode(4))),
                new ListNode(1,new ListNode(2,new ListNode(4, new ListNode(5)))),
            };
        }
    }
}