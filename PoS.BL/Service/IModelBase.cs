namespace PoS.BL.Service
{
	public interface IModelBase<J>
	{
		void Add(string iUser, J iModel);
		void Update(string iUser, J iModel);
		void Delete(J iModel);
	}
}
