// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: dettacare.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dettacare {

  /// <summary>Holder for reflection information generated from dettacare.proto</summary>
  public static partial class DettacareReflection {

    #region Descriptor
    /// <summary>File descriptor for dettacare.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DettacareReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9kZXR0YWNhcmUucHJvdG8SCWRldHRhY2FyZSIvCgxMb2dpblJlcXVlc3QS",
            "DQoFZW1haWwYASABKAkSEAoIcGFzc3dvcmQYAiABKAkiGwoIUmVzcG9uc2US",
            "DwoHbWVzc2FnZRgBIAEoCTJJCgxVc2VyRnVuY3Rpb24SOQoHR29Mb2dpbhIX",
            "LmRldHRhY2FyZS5Mb2dpblJlcXVlc3QaEy5kZXR0YWNhcmUuUmVzcG9uc2Ui",
            "AEIrChFpby5ncnBjLmRldHRhY2FyZUIORGV0dGFDYXJlUHJvdG9QAaICA0hM",
            "V2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dettacare.LoginRequest), global::Dettacare.LoginRequest.Parser, new[]{ "Email", "Password" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dettacare.Response), global::Dettacare.Response.Parser, new[]{ "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LoginRequest : pb::IMessage<LoginRequest> {
    private static readonly pb::MessageParser<LoginRequest> _parser = new pb::MessageParser<LoginRequest>(() => new LoginRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dettacare.DettacareReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginRequest(LoginRequest other) : this() {
      email_ = other.email_;
      password_ = other.password_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginRequest Clone() {
      return new LoginRequest(this);
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 1;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Email != other.Email) return false;
      if (Password != other.Password) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Email.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Email);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginRequest other) {
      if (other == null) {
        return;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Email = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dettacare.DettacareReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      message_ = other.message_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
