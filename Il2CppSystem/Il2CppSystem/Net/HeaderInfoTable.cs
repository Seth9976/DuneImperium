using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020001CE RID: 462
	public class HeaderInfoTable : Object
	{
		// Token: 0x06001C83 RID: 7299 RVA: 0x0008B620 File Offset: 0x00089820
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfoTable()
		{
			Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfoTable");
			HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "HeaderHashTable");
			HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "UnknownHeaderInfo");
			HeaderInfoTable.NativeFieldInfoPtr_SingleParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "SingleParser");
			HeaderInfoTable.NativeFieldInfoPtr_MultiParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "MultiParser");
			HeaderInfoTable.NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100667669);
			HeaderInfoTable.NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100667670);
			HeaderInfoTable.NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100667672);
			HeaderInfoTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100667673);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0008B6E8 File Offset: 0x000898E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476068, XrefRangeEnd = 476072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseSingleValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0008B72C File Offset: 0x0008992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476072, XrefRangeEnd = 476096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseMultiValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000892 RID: 2194
		public unsafe HeaderInfo this[string name]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 476106, RefRangeEnd = 476110, XrefRangeStart = 476096, XrefRangeEnd = 476106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0008B7C0 File Offset: 0x000899C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfoTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0000C203 File Offset: 0x0000A403
		public HeaderInfoTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0008B7FC File Offset: 0x000899FC
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0000C20C File Offset: 0x0000A40C
		public unsafe static Hashtable HeaderHashTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0008B824 File Offset: 0x00089A24
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0000C21E File Offset: 0x0000A41E
		public unsafe static HeaderInfo UnknownHeaderInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0008B84C File Offset: 0x00089A4C
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0000C230 File Offset: 0x0000A430
		public unsafe static HeaderParser SingleParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_SingleParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_SingleParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0008B874 File Offset: 0x00089A74
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0000C242 File Offset: 0x0000A442
		public unsafe static HeaderParser MultiParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_MultiParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_MultiParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_HeaderHashTable;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeFieldInfoPtr_UnknownHeaderInfo;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeFieldInfoPtr_SingleParser;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeFieldInfoPtr_MultiParser;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
