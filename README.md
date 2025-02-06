# FAQ Classification Model

This project implements a machine learning model using ML.NET to classify Frequently Asked Questions (FAQs) into predefined categories. It utilizes the Stochastic Dual Coordinate Ascent (SDCA) algorithm for multiclass classification, utilizing text preprocessing techniques. Key metrics include macro accuracy and log-loss to enhance user support efficiency.

## 📂 Project Structure

- [**DataAugmentation.cs**](./DataAugmentation.cs): Data enhancement and transformation.
- [**MyModel.cs**](./MyModel.cs): Model structure for FAQ classification.
- [**Program.cs**](./Program.cs): Main execution file.
- [**faq_dataset.csv**](./faq_dataset.csv): Dataset for training and testing.
- [**faQClassification.sln**](./faQClassification.sln): Visual Studio solution file.
- [**faQClassification.csproj**](./faQClassification.csproj): Project definition.
- [**LICENSE**](./LICENSE): License information.
- [**README.md**](./README.md): Project documentation.
- [**CODE_OF_CONDUCT.md**](./CODE_OF_CONDUCT.md): Code of Conduct for contributors.
- [**CONTRIBUTING.md**](./CONTRIBUTING.md): Guidelines for contributing to the project.

## 🚀 Features

- Multiclass FAQ classification using SDCA algorithm.
- Text preprocessing and data augmentation.
- Evaluation with macro accuracy and log-loss metrics.

## Getting Started

### Prerequisites

- **.NET SDK**: Install the latest version of the .NET SDK from [Microsoft's official site](https://dotnet.microsoft.com/download).
- **ML.NET**: Integrated into the project for machine learning operations.

### 🛠️ Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/iamrealvinnu/FAQ-Classification-Model.git
    cd FAQ-Classification-Model
    ```

2. Build the project:
    ```sh
    dotnet build
    ```

3. Run the project:
    ```sh
    dotnet run --project src/Program.cs
    ```

## 📊 Data
The dataset file faq_dataset.csv contains FAQs and their respective categories. Ensure that the file is placed in the appropriate directory for successful execution.

## Evaluation
The model's performance is evaluated using metrics such as log-loss and macro accuracy.

## Usage
The trained model can classify new questions into predefined categories.

## 🤝 Contributing
Contributions are welcome! Feel free to fork the repository and submit a pull request with your improvements.
- See [CONTRIBUTING.md](./CONTRIBUTING.md) for more details.
- Follow the [CODE_OF_CONDUCT.md](./CODE_OF_CONDUCT.md) during your interactions.

## 📄 License
This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.
