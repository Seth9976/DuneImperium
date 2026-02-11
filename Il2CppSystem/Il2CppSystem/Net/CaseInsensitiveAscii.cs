using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001C7 RID: 455
	public class CaseInsensitiveAscii : Object
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x00089408 File Offset: 0x00087608
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveAscii()
		{
			Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CaseInsensitiveAscii");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr);
			CaseInsensitiveAscii.NativeFieldInfoPtr_StaticInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, "StaticInstance");
			CaseInsensitiveAscii.NativeFieldInfoPtr_AsciiToLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, "AsciiToLower");
			CaseInsensitiveAscii.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100667584);
			CaseInsensitiveAscii.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100667585);
			CaseInsensitiveAscii.NativeMethodInfoPtr_FastGetHashCode_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100667586);
			CaseInsensitiveAscii.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100667587);
			CaseInsensitiveAscii.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr, 100667588);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000894C4 File Offset: 0x000876C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475404, XrefRangeEnd = 475414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object myObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00089514 File Offset: 0x00087714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475414, XrefRangeEnd = 475424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object firstObject, Object secondObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00089574 File Offset: 0x00087774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 475431, RefRangeEnd = 475433, XrefRangeStart = 475424, XrefRangeEnd = 475431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FastGetHashCode(string myString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(myString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_FastGetHashCode_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000895C4 File Offset: 0x000877C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 475433, XrefRangeEnd = 475446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object firstObject, Object secondObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00089624 File Offset: 0x00087824
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveAscii()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveAscii>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveAscii.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0000BF51 File Offset: 0x0000A151
		public CaseInsensitiveAscii(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00089660 File Offset: 0x00087860
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0000BF5A File Offset: 0x0000A15A
		public unsafe static CaseInsensitiveAscii StaticInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CaseInsensitiveAscii.NativeFieldInfoPtr_StaticInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveAscii>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CaseInsensitiveAscii.NativeFieldInfoPtr_StaticInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x00089688 File Offset: 0x00087888
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0000BF6C File Offset: 0x0000A16C
		public unsafe static Il2CppStructArray<byte> AsciiToLower
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CaseInsensitiveAscii.NativeFieldInfoPtr_AsciiToLower, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CaseInsensitiveAscii.NativeFieldInfoPtr_AsciiToLower, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeFieldInfoPtr_StaticInstance;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_AsciiToLower;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_FastGetHashCode_Private_Int32_String_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
