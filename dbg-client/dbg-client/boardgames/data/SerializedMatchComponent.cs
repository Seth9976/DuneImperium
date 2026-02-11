using System;
using Canis;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x02000194 RID: 404
	public class SerializedMatchComponent : VersionedDataComponent
	{
		// Token: 0x06001200 RID: 4608 RVA: 0x00056DF8 File Offset: 0x00054FF8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedMatchComponent()
		{
			Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "SerializedMatchComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr);
			SerializedMatchComponent.NativeFieldInfoPtr__Match_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr, "<Match>k__BackingField");
			SerializedMatchComponent.NativeMethodInfoPtr_get_Match_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr, 100665817);
			SerializedMatchComponent.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr, 100665818);
			SerializedMatchComponent.NativeMethodInfoPtr_get_IsClientConfigurable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr, 100665819);
			SerializedMatchComponent.NativeMethodInfoPtr_ConfigurePlayer_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr, 100665820);
			SerializedMatchComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr, 100665821);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00056EA0 File Offset: 0x000550A0
		public unsafe MatchInitData Match
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchComponent.NativeMethodInfoPtr_get_Match_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00056EE0 File Offset: 0x000550E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 515668, RefRangeEnd = 515675, XrefRangeStart = 515665, XrefRangeEnd = 515668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedMatchComponent(MatchInitData matchInitData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedMatchComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchComponent.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00056F2C File Offset: 0x0005512C
		public unsafe virtual bool IsClientConfigurable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515675, XrefRangeEnd = 515690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMatchComponent.NativeMethodInfoPtr_get_IsClientConfigurable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00056F74 File Offset: 0x00055174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515715, RefRangeEnd = 515716, XrefRangeStart = 515690, XrefRangeEnd = 515715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigurePlayer(int playerSlot, int aiLevel, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerSlot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedMatchComponent.NativeMethodInfoPtr_ConfigurePlayer_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00056FD4 File Offset: 0x000551D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515716, XrefRangeEnd = 515720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedMatchComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		public SerializedMatchComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00057018 File Offset: 0x00055218
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x0000A9CD File Offset: 0x00008BCD
		public unsafe MatchInitData _Match_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMatchComponent.NativeFieldInfoPtr__Match_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedMatchComponent.NativeFieldInfoPtr__Match_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeFieldInfoPtr__Match_k__BackingField;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_get_Match_Public_get_MatchInitData_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClientConfigurable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_ConfigurePlayer_Public_Void_Int32_Int32_String_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
