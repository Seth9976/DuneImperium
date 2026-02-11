using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001EC RID: 492
	public class XmlValueConverter : Object
	{
		// Token: 0x0600292F RID: 10543 RVA: 0x000BEE14 File Offset: 0x000BD014
		// Note: this type is marked as 'beforefieldinit'.
		static XmlValueConverter()
		{
			Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlValueConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669231);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669232);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669233);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669234);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669235);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669236);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669237);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669238);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669239);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669240);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669241);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669242);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669243);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669244);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669245);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669246);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669247);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669248);
			XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669249);
			XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669250);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669251);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669252);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669253);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669254);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669255);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669256);
			XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669257);
			XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669258);
			XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669259);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669260);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669261);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669262);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669263);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669264);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669265);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669266);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669267);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669268);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669269);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669270);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669271);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669272);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669273);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669274);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669275);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669276);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669277);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669278);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669279);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669280);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669281);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669282);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669283);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669284);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669285);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669286);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669287);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669288);
			XmlValueConverter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100669289);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000BF2E0 File Offset: 0x000BD4E0
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000BF334 File Offset: 0x000BD534
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000BF388 File Offset: 0x000BD588
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000BF3DC File Offset: 0x000BD5DC
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000BF430 File Offset: 0x000BD630
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000BF488 File Offset: 0x000BD688
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000BF4E0 File Offset: 0x000BD6E0
		[CallerCount(0)]
		public unsafe virtual int ToInt32(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000BF534 File Offset: 0x000BD734
		[CallerCount(0)]
		public unsafe virtual int ToInt32(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000BF588 File Offset: 0x000BD788
		[CallerCount(0)]
		public unsafe virtual int ToInt32(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000BF5DC File Offset: 0x000BD7DC
		[CallerCount(0)]
		public unsafe virtual int ToInt32(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000BF630 File Offset: 0x000BD830
		[CallerCount(0)]
		public unsafe virtual int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000BF688 File Offset: 0x000BD888
		[CallerCount(0)]
		public unsafe virtual int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000BF6E0 File Offset: 0x000BD8E0
		[CallerCount(0)]
		public unsafe virtual long ToInt64(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000BF734 File Offset: 0x000BD934
		[CallerCount(0)]
		public unsafe virtual long ToInt64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000BF788 File Offset: 0x000BD988
		[CallerCount(0)]
		public unsafe virtual long ToInt64(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000BF7DC File Offset: 0x000BD9DC
		[CallerCount(0)]
		public unsafe virtual long ToInt64(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000BF830 File Offset: 0x000BDA30
		[CallerCount(0)]
		public unsafe virtual long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000BF888 File Offset: 0x000BDA88
		[CallerCount(0)]
		public unsafe virtual long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000BF8E0 File Offset: 0x000BDAE0
		[CallerCount(0)]
		public unsafe virtual Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000BF938 File Offset: 0x000BDB38
		[CallerCount(0)]
		public unsafe virtual Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000BF990 File Offset: 0x000BDB90
		[CallerCount(0)]
		public unsafe virtual double ToDouble(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000BF9E4 File Offset: 0x000BDBE4
		[CallerCount(0)]
		public unsafe virtual double ToDouble(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000BFA38 File Offset: 0x000BDC38
		[CallerCount(0)]
		public unsafe virtual double ToDouble(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000BFA8C File Offset: 0x000BDC8C
		[CallerCount(0)]
		public unsafe virtual double ToDouble(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000BFAE0 File Offset: 0x000BDCE0
		[CallerCount(0)]
		public unsafe virtual double ToDouble(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000BFB38 File Offset: 0x000BDD38
		[CallerCount(0)]
		public unsafe virtual double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000BFB90 File Offset: 0x000BDD90
		[CallerCount(0)]
		public unsafe virtual float ToSingle(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000BFBE4 File Offset: 0x000BDDE4
		[CallerCount(0)]
		public unsafe virtual float ToSingle(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000BFC3C File Offset: 0x000BDE3C
		[CallerCount(0)]
		public unsafe virtual float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000BFC94 File Offset: 0x000BDE94
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000BFCE8 File Offset: 0x000BDEE8
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000BFD3C File Offset: 0x000BDF3C
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000BFD90 File Offset: 0x000BDF90
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000BFDE4 File Offset: 0x000BDFE4
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000BFE38 File Offset: 0x000BE038
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000BFE90 File Offset: 0x000BE090
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000BFEE8 File Offset: 0x000BE0E8
		[CallerCount(0)]
		public unsafe virtual DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000BFF3C File Offset: 0x000BE13C
		[CallerCount(0)]
		public unsafe virtual DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000BFF94 File Offset: 0x000BE194
		[CallerCount(0)]
		public unsafe virtual DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x000BFFEC File Offset: 0x000BE1EC
		[CallerCount(0)]
		public unsafe virtual string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000C003C File Offset: 0x000BE23C
		[CallerCount(0)]
		public unsafe virtual string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000C008C File Offset: 0x000BE28C
		[CallerCount(0)]
		public unsafe virtual string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000C00DC File Offset: 0x000BE2DC
		[CallerCount(0)]
		public unsafe virtual string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000C012C File Offset: 0x000BE32C
		[CallerCount(0)]
		public unsafe virtual string ToString(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000C017C File Offset: 0x000BE37C
		[CallerCount(0)]
		public unsafe virtual string ToString(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000C01CC File Offset: 0x000BE3CC
		[CallerCount(0)]
		public unsafe virtual string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000C021C File Offset: 0x000BE41C
		[CallerCount(0)]
		public unsafe virtual string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000C026C File Offset: 0x000BE46C
		[CallerCount(0)]
		public unsafe virtual string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000C02C0 File Offset: 0x000BE4C0
		[CallerCount(0)]
		public unsafe virtual string ToString(Object value, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000C0328 File Offset: 0x000BE528
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(bool value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000C0394 File Offset: 0x000BE594
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(int value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000C0400 File Offset: 0x000BE600
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(long value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000C046C File Offset: 0x000BE66C
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Decimal value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000C04D8 File Offset: 0x000BE6D8
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(double value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000C0544 File Offset: 0x000BE744
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(DateTime value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000C05B0 File Offset: 0x000BE7B0
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000C0630 File Offset: 0x000BE830
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x000C06A0 File Offset: 0x000BE8A0
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x000C0720 File Offset: 0x000BE920
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlValueConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValueConverter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00011722 File Offset: 0x0000F922
		public XmlValueConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int64_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Double_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_DateTime_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Boolean_0;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Int64_0;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Double_0;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Boolean_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Int32_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Double_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_DateTime_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_String_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_String_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_Object_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Boolean_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int32_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int64_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_DateTime_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_String_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Object_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Double_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_String_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Boolean_0;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int64_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Double_0;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_DateTimeOffset_0;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_String_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Object_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_DateTime_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_String_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_Object_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int64_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Decimal_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Single_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Double_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTime_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTimeOffset_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Boolean_Type_0;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int32_Type_0;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int64_Type_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Decimal_Type_0;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Double_Type_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_DateTime_Type_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
