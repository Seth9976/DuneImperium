using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	// Token: 0x02000083 RID: 131
	public class DataNotReadyException : Exception
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		// Note: this type is marked as 'beforefieldinit'.
		static DataNotReadyException()
		{
			Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Formatting", "DataNotReadyException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr);
			DataNotReadyException.NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr, "<Text>k__BackingField");
			DataNotReadyException.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr, 100664447);
			DataNotReadyException.NativeMethodInfoPtr_set_Text_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr, 100664448);
			DataNotReadyException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr, 100664449);
			DataNotReadyException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr, 100664450);
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00020C3C File Offset: 0x0001EE3C
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00020C74 File Offset: 0x0001EE74
		public unsafe string Text
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataNotReadyException.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataNotReadyException.NativeMethodInfoPtr_set_Text_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074184, XrefRangeEnd = 1074188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataNotReadyException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataNotReadyException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074188, XrefRangeEnd = 1074193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataNotReadyException(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataNotReadyException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataNotReadyException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000461D File Offset: 0x0000281D
		public DataNotReadyException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00020D40 File Offset: 0x0001EF40
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00004626 File Offset: 0x00002826
		public unsafe string _Text_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataNotReadyException.NativeFieldInfoPtr__Text_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataNotReadyException.NativeFieldInfoPtr__Text_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr__Text_k__BackingField;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Private_set_Void_String_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
