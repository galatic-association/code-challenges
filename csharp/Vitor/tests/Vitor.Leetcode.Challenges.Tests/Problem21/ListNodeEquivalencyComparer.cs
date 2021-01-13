using FluentAssertions.Equivalency;

namespace Vitor.Leetcode.Challenges.Problem21.Tests
{
    public class ListNodeEquivalencyComparer : IEquivalencyStep
    {
        public bool CanHandle(IEquivalencyValidationContext context, IEquivalencyAssertionOptions config)
        {
            return context.Subject is ListNode
                && context.Expectation is ListNode;
        }

        public bool Handle(IEquivalencyValidationContext context, IEquivalencyValidator parent, IEquivalencyAssertionOptions config)
        {
            var subjectNode = (ListNode)context.Subject;
            var expectationNode = (ListNode)context.Expectation;

            if((subjectNode is null && expectationNode is not null) || (subjectNode is not null && expectationNode is  null))
                return false;

            while (subjectNode is not null && expectationNode is not null)
            {
                if (subjectNode.val != expectationNode.val)
                    return false;
                subjectNode = subjectNode.next;
                expectationNode = expectationNode.next;
            }

            return true;
        }
    }
}