using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x0200007C RID: 124
	public class ParsingErrorEventArgs : EventArgs
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x0001F690 File Offset: 0x0001D890
		// Note: this type is marked as 'beforefieldinit'.
		static ParsingErrorEventArgs()
		{
			Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "ParsingErrorEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr);
			ParsingErrorEventArgs.NativeFieldInfoPtr__Errors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, "<Errors>k__BackingField");
			ParsingErrorEventArgs.NativeFieldInfoPtr__ThrowsException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, "<ThrowsException>k__BackingField");
			ParsingErrorEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ParsingErrors_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, 100664393);
			ParsingErrorEventArgs.NativeMethodInfoPtr_get_Errors_Public_get_ParsingErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, 100664394);
			ParsingErrorEventArgs.NativeMethodInfoPtr_set_Errors_Internal_set_Void_ParsingErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, 100664395);
			ParsingErrorEventArgs.NativeMethodInfoPtr_get_ThrowsException_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, 100664396);
			ParsingErrorEventArgs.NativeMethodInfoPtr_set_ThrowsException_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr, 100664397);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001F74C File Offset: 0x0001D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073929, XrefRangeEnd = 1073934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParsingErrorEventArgs(ParsingErrors errors, bool throwsException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingErrorEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwsException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_ParsingErrors_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		public unsafe ParsingErrors Errors
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorEventArgs.NativeMethodInfoPtr_get_Errors_Public_get_ParsingErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParsingErrors>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorEventArgs.NativeMethodInfoPtr_set_Errors_Internal_set_Void_ParsingErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001F82C File Offset: 0x0001DA2C
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0001F868 File Offset: 0x0001DA68
		public unsafe bool ThrowsException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorEventArgs.NativeMethodInfoPtr_get_ThrowsException_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrorEventArgs.NativeMethodInfoPtr_set_ThrowsException_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004421 File Offset: 0x00002621
		public ParsingErrorEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0000442A File Offset: 0x0000262A
		public unsafe ParsingErrors _Errors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrorEventArgs.NativeFieldInfoPtr__Errors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParsingErrors>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrorEventArgs.NativeFieldInfoPtr__Errors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00004449 File Offset: 0x00002649
		public unsafe bool _ThrowsException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrorEventArgs.NativeFieldInfoPtr__ThrowsException_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrorEventArgs.NativeFieldInfoPtr__ThrowsException_k__BackingField)) = value;
			}
		}

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr__Errors_k__BackingField;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr__ThrowsException_k__BackingField;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParsingErrors_Boolean_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_Errors_Public_get_ParsingErrors_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_set_Errors_Internal_set_Void_ParsingErrors_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowsException_Public_get_Boolean_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowsException_Internal_set_Void_Boolean_0;
	}
}
