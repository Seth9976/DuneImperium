using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Core.Output
{
	// Token: 0x02000081 RID: 129
	public class StringOutput : Object
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x0002062C File Offset: 0x0001E82C
		// Note: this type is marked as 'beforefieldinit'.
		static StringOutput()
		{
			Il2CppClassPointerStore<StringOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Output", "StringOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringOutput>.NativeClassPtr);
			StringOutput.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, "output");
			StringOutput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664435);
			StringOutput.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664436);
			StringOutput.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664437);
			StringOutput.NativeMethodInfoPtr_SetCapacity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664438);
			StringOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664439);
			StringOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664440);
			StringOutput.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664441);
			StringOutput.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOutput>.NativeClassPtr, 100664442);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00020710 File Offset: 0x0001E910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074163, RefRangeEnd = 1074164, XrefRangeStart = 1074157, XrefRangeEnd = 1074163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringOutput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOutput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0002074C File Offset: 0x0001E94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074164, XrefRangeEnd = 1074170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringOutput(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOutput>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00020794 File Offset: 0x0001E994
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringOutput(StringBuilder output)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOutput>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000207E0 File Offset: 0x0001E9E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1074172, RefRangeEnd = 1074176, XrefRangeStart = 1074170, XrefRangeEnd = 1074172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr_SetCapacity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00020820 File Offset: 0x0001EA20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013194, RefRangeEnd = 1013198, XrefRangeStart = 1013194, XrefRangeEnd = 1013198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string text, IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00020874 File Offset: 0x0001EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074176, XrefRangeEnd = 1074178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000208E8 File Offset: 0x0001EAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074180, RefRangeEnd = 1074181, XrefRangeStart = 1074178, XrefRangeEnd = 1074180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOutput.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0002091C File Offset: 0x0001EB1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 549125, RefRangeEnd = 549132, XrefRangeStart = 549125, XrefRangeEnd = 549132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringOutput.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000045CD File Offset: 0x000027CD
		public StringOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00020960 File Offset: 0x0001EB60
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x000045D6 File Offset: 0x000027D6
		public unsafe StringBuilder output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOutput.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOutput.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Void_Int32_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_IFormattingInfo_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_IFormattingInfo_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
