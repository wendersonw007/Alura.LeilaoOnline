---
## 📘 Projeto de Testes Automatizados com Selenium em C# - {{QA.Automacao.Leilao}}

### 🧪 Sobre o Projeto

Este projeto foi desenvolvido com o objetivo de demonstrar testes automatizados utilizando **Selenium WebDriver** com **C#**. A arquitetura adotada segue boas práticas como o padrão **Page Object** e a organização dos testes considerando o conceito de **pirâmide de testes** (Unit > Service > UI).

---

### 🧰 Tecnologias e Ferramentas Utilizadas

* C# (.NET)
* Selenium WebDriver
* ChromeDriver 
* xUnit (para execução dos testes)

  * `Selenium.WebDriver`
  * `WebDriverManager`
  * `xunit`
  * `xunit.runner.visualstudio`

---

### 🧱 Estrutura do Projeto

```
/Tests
  ├── Fixtures
  ├── Pages
  ├── Tests
  └── Drivers
```

* `PagesObjects`: Implementação do padrão **Page Object**.
* `Fixtures`: Contexto compartilhado entre testes (uso de `ClassFixture` e `CollectionFixture`).
* `Tests`: Casos de testes organizados por funcionalidade.

---

### 🔁 Ciclo de Vida dos Testes

Utiliza os métodos:

* `Setup` / `TearDown` com construtores e `Dispose()`.
* Compartilhamento de contexto com `ClassFixture` e `CollectionFixture`.

---

### 🔎 Comandos e Métodos Importantes

```csharp
driver.Navigate().GoToUrl("...");
driver.Title;
driver.PageSource;

element.FindElement(By.Id("..."));
element.SendKeys("...");
element.Click();
element.Submit();
element.Displayed;
element.Text;
```

### 🧼 Boas Práticas

* Uso de Page Object para evitar repetição de código.
* Separação clara entre lógica de teste e lógica de navegação.
* Reutilização de contexto com Fixtures.

---
