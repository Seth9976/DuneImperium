using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001A RID: 26
	public class NativeThrowsAttribute : Attribute
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000043BC File Offset: 0x000025BC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeThrowsAttribute()
		{
			Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeThrowsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr);
			NativeThrowsAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr, "<ThrowsException>k__BackingField");
			NativeThrowsAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr, 100663353);
			NativeThrowsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr, 100663354);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002674 File Offset: 0x00000874
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00004428 File Offset: 0x00002628
		public unsafe virtual bool ThrowsException
		{
			get
			{
				return this._ThrowsException_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeThrowsAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004468 File Offset: 0x00002668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeThrowsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeThrowsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeThrowsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002650 File Offset: 0x00000850
		public NativeThrowsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000044A4 File Offset: 0x000026A4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002659 File Offset: 0x00000859
		public unsafe bool _ThrowsException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeThrowsAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeThrowsAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField)) = value;
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr__ThrowsException_k__BackingField;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
