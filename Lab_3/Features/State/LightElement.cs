namespace LightHTML.Features.State
{
    public class LightElement
    {
        private IState state;

        public LightElement(IState initialState)
        {
            state = initialState;
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void Render()
        {
            state.Render();
        }
    }
}
