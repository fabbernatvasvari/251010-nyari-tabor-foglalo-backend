using System;

public class Camp
{
	private int _id;
	private static int _nextId = 1;

	public Date startDate = Date.Today;
	public Date endDate = Date.Today + 7 days;
    public Camp()
	{
		_id = _nextId++;
    }

	public Camp(Date startDate, Date endDate)
	{
		_id = _nextId++;
		this.startDate = startDate;
		this.endDate = endDate;
    }
}
