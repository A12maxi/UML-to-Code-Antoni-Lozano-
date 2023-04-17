using System;

public class Account {
	public string IBAN;
	protected float amount;

	public bool Transaction() {
		throw new System.NotImplementedException("Not implemented");
	}

	private Customer customer;

	private Transaction transaction;

}
