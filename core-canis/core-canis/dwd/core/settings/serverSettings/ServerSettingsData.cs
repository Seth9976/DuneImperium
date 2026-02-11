using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings
{
	// Token: 0x020000B9 RID: 185
	public class ServerSettingsData : DataComponent
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x00040AF4 File Offset: 0x0003ECF4
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSettingsData()
		{
			Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings", "ServerSettingsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr);
			ServerSettingsData.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr, "attribute");
			ServerSettingsData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr, 100664950);
			ServerSettingsData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr, 100664951);
			ServerSettingsData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr, 100664952);
			ServerSettingsData.NativeMethodInfoPtr_GetAll_Public_Void_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr, 100664953);
			ServerSettingsData.NativeMethodInfoPtr_TryGetValue_Public_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr, 100664954);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00040B9C File Offset: 0x0003ED9C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSettingsData(IAttribute<Dictionary<int, int>> attribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingsData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingsData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00040BE8 File Offset: 0x0003EDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863923, XrefRangeEnd = 863928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSettingsData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00040C34 File Offset: 0x0003EE34
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863928, XrefRangeEnd = 863932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingsData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00040C70 File Offset: 0x0003EE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863957, RefRangeEnd = 863959, XrefRangeStart = 863932, XrefRangeEnd = 863957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAll(IDictionary<int, int> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingsData.NativeMethodInfoPtr_GetAll_Public_Void_IDictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00040CB4 File Offset: 0x0003EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863959, XrefRangeEnd = 863967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(int key, out int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingsData.NativeMethodInfoPtr_TryGetValue_Public_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000062B3 File Offset: 0x000044B3
		public ServerSettingsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00040D0C File Offset: 0x0003EF0C
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000062BC File Offset: 0x000044BC
		public unsafe IAttribute<Dictionary<int, int>> attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingsData.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<int, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingsData.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_Dictionary_2_Int32_Int32_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Void_IDictionary_2_Int32_Int32_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_Int32_byref_Int32_0;
	}
}
