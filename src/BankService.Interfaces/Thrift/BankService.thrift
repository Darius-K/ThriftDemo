namespace csharp BankService.Interfaces

struct Account {
	1: required i64 accountNumber;
	2: required i64 balance;
	3: required i64 creditAmount;
	4: required string productName;
	5: required string accountOpened;
	6: required bool active;
	7: required string currencyCode;
	8: required i32 interestRate;
	9: required i32 accumulatedInterest;
}

service AccountService {
	list<Account> GetAccounts(1: i64 customerId);
	i64 CreateAccount(1: i64 customerId, 2: Account account);
}
