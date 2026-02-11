using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.save
{
	// Token: 0x020000BD RID: 189
	public class DeleteOne : SaveRequest
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x000418F4 File Offset: 0x0003FAF4
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteOne()
		{
			Il2CppClassPointerStore<DeleteOne>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.save", "DeleteOne");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteOne>.NativeClassPtr);
			DeleteOne.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteOne>.NativeClassPtr, "key");
			DeleteOne.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteOne>.NativeClassPtr, 100664991);
			DeleteOne.NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteOne>.NativeClassPtr, 100664992);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00041960 File Offset: 0x0003FB60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 767585, RefRangeEnd = 767587, XrefRangeStart = 767585, XrefRangeEnd = 767587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeleteOne(int key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeleteOne>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteOne.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000419A8 File Offset: 0x0003FBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864203, XrefRangeEnd = 864208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyTo(IDictionary<int, int> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteOne.NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0000643A File Offset: 0x0000463A
		public DeleteOne(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000419F8 File Offset: 0x0003FBF8
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00006443 File Offset: 0x00004643
		public unsafe int key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteOne.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeleteOne.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Public_Virtual_Void_IDictionary_2_Int32_Int32_0;
	}
}
