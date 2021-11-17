import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class BankAccountTest {
    @Test
    void Debit_WithValidAmount_UpdatesBalance() {
        double beginningBalance = 11.99;
        double debitAmount = 4.55;
        double expected = 7.44;
        BankAccount account = new BankAccount("Mr. JRGS2021", beginningBalance);

        // acción a probar
        try {
            account.Debit(debitAmount);
        }
        // En este caso, si se produce una excepción, es porque ha fallado la prueba
        catch( Exception e ) {
            Assertions.fail();
        }

        // afirmación de la prueba (valor esperado Vs. Valor obtenido)
        double actual = account.GetBalance();
        Assertions.assertEquals(expected, actual, 0.001, "Account not debited correctly");
    }

    @Test
    void Debit_WithFrozenAccount_ProducesException() {
        // preparación del caso de prueba
        double beginningBalance = 11.99;
        double debitAmount = 4.55;
        BankAccount account = new BankAccount("Mr. JRGS2021", beginningBalance);
        account.FreezeAccount(); // Congelamos la cuenta: no se pueden hacer adeudos
        //Assertions.assertThrows(Exception.class, () -> account.Debit(debitAmount) );
        Throwable myException = Assertions.assertThrows(IllegalArgumentException.class, () -> account.Debit(debitAmount));
        Assertions.assertEquals(myException.getMessage(), BankAccount.DebitAmountExceedsBalanceMessage);

    }

}
