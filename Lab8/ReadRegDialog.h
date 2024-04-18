#pragma once

namespace Registry {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// ������ ��� ReadRegDialog
	/// </summary>
	public ref class ReadRegDialog : public System::Windows::Forms::Form
	{
	public:
		ReadRegDialog(void)
		{
			InitializeComponent();
			//
			//TODO: �������� ��� ������������
			//
		}

	protected:
		/// <summary>
		/// ���������� ��� ������������ �������.
		/// </summary>
		~ReadRegDialog()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label1;
	protected:
	public: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Button^ button1;
	private: HRESULT ModifyPrivilege(
		IN LPCTSTR szPrivilege,
		IN BOOL fEnable)
	{
		HRESULT hr = S_OK;
		TOKEN_PRIVILEGES NewState;
		LUID             luid;
		HANDLE hToken = NULL;

		// Open the process token for this process.
		if (!OpenProcessToken(GetCurrentProcess(),
			TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY,
			&hToken))
		{
			printf("Failed OpenProcessToken\n");
			return ERROR_FUNCTION_FAILED;
		}

		// Get the local unique ID for the privilege.
		if (!LookupPrivilegeValue(NULL,
			szPrivilege,
			&luid))
		{
			CloseHandle(hToken);
			printf("Failed LookupPrivilegeValue\n");
			return ERROR_FUNCTION_FAILED;
		}

		// Assign values to the TOKEN_PRIVILEGE structure.
		NewState.PrivilegeCount = 1;
		NewState.Privileges[0].Luid = luid;
		NewState.Privileges[0].Attributes =
			(fEnable ? SE_PRIVILEGE_ENABLED : 0);

		// Adjust the token privilege.
		if (!AdjustTokenPrivileges(hToken,
			FALSE,
			&NewState,
			0,
			NULL,
			NULL))
		{
			printf("Failed AdjustTokenPrivileges\n");
			hr = ERROR_FUNCTION_FAILED;
		}

		// Close the handle.
		CloseHandle(hToken);

		return hr;
	}
	public:

	private:
		/// <summary>
		/// ������������ ���������� ������������.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// ��������� ����� ��� ��������� ������������ � �� ��������� 
		/// ���������� ����� ������ � ������� ��������� ����.
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Courier New", 13.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(23, 37);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(180, 25);
			this->label1->TabIndex = 0;
			this->label1->Text = L"������� ���:";
			// 
			// textBox1
			// 
			this->textBox1->Font = (gcnew System::Drawing::Font(L"Courier New", 13.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->textBox1->Location = System::Drawing::Point(209, 34);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(366, 34);
			this->textBox1->TabIndex = 1;
			// 
			// button1
			// 
			this->button1->DialogResult = System::Windows::Forms::DialogResult::OK;
			this->button1->Font = (gcnew System::Drawing::Font(L"Courier New", 13.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button1->Location = System::Drawing::Point(217, 99);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(169, 35);
			this->button1->TabIndex = 2;
			this->button1->Text = L"OK";
			this->button1->UseVisualStyleBackColor = true;
			// 
			// ReadRegDialog
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(593, 154);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Name = L"ReadRegDialog";
			this->Text = L"ReadRegDialog";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	};
}
