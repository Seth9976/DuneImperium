using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x0200000C RID: 12
	public sealed class VFXOutputEventArgs : ValueType
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00004D98 File Offset: 0x00002F98
		// Note: this type is marked as 'beforefieldinit'.
		static VFXOutputEventArgs()
		{
			Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXOutputEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr);
			VFXOutputEventArgs.NativeFieldInfoPtr__nameId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, "<nameId>k__BackingField");
			VFXOutputEventArgs.NativeFieldInfoPtr__eventAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, "<eventAttribute>k__BackingField");
			VFXOutputEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, 100663328);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004E04 File Offset: 0x00003004
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXOutputEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000029D3 File Offset: 0x00000BD3
		public VFXOutputEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000029DC File Offset: 0x00000BDC
		public VFXOutputEventArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00004E64 File Offset: 0x00003064
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000029EE File Offset: 0x00000BEE
		public unsafe int _nameId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__nameId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__nameId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002A09 File Offset: 0x00000C09
		public unsafe VFXEventAttribute _eventAttribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__eventAttribute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXOutputEventArgs.NativeFieldInfoPtr__eventAttribute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002A28 File Offset: 0x00000C28
		public int nameId
		{
			get
			{
				return this._nameId_k__BackingField;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002A30 File Offset: 0x00000C30
		public VFXEventAttribute eventAttribute
		{
			get
			{
				return this._eventAttribute_k__BackingField;
			}
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr__nameId_k__BackingField;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr__eventAttribute_k__BackingField;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0;
	}
}
