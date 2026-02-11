using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMono.Btls
{
	// Token: 0x0200003A RID: 58
	public static class MonoBtlsUtils : Object
	{
		// Token: 0x06000398 RID: 920 RVA: 0x00029700 File Offset: 0x00027900
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsUtils()
		{
			Il2CppClassPointerStore<MonoBtlsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsUtils>.NativeClassPtr);
			MonoBtlsUtils.NativeFieldInfoPtr_emailOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsUtils>.NativeClassPtr, "emailOid");
			MonoBtlsUtils.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsUtils>.NativeClassPtr, 100663941);
			MonoBtlsUtils.NativeMethodInfoPtr_AppendEntry_Private_Static_Boolean_StringBuilder_MonoBtlsX509Name_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsUtils>.NativeClassPtr, 100663942);
			MonoBtlsUtils.NativeMethodInfoPtr_FormatName_Public_Static_String_MonoBtlsX509Name_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsUtils>.NativeClassPtr, 100663943);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00029780 File Offset: 0x00027980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431350, XrefRangeEnd = 431351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsUtils.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000297D4 File Offset: 0x000279D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431448, RefRangeEnd = 431450, XrefRangeStart = 431351, XrefRangeEnd = 431448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(separator);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quotes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsUtils.NativeMethodInfoPtr_AppendEntry_Private_Static_Boolean_StringBuilder_MonoBtlsX509Name_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00029858 File Offset: 0x00027A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431474, RefRangeEnd = 431475, XrefRangeStart = 431450, XrefRangeEnd = 431474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reversed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(separator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quotes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsUtils.NativeMethodInfoPtr_FormatName_Public_Static_String_MonoBtlsX509Name_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003321 File Offset: 0x00001521
		public MonoBtlsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000298C4 File Offset: 0x00027AC4
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000332A File Offset: 0x0000152A
		public unsafe static Il2CppStructArray<byte> emailOid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsUtils.NativeFieldInfoPtr_emailOid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsUtils.NativeFieldInfoPtr_emailOid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_emailOid;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_AppendEntry_Private_Static_Boolean_StringBuilder_MonoBtlsX509Name_Int32_String_Boolean_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_FormatName_Public_Static_String_MonoBtlsX509Name_Boolean_String_Boolean_0;
	}
}
