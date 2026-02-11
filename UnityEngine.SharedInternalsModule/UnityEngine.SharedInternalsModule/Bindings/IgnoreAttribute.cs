using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001B RID: 27
	public class IgnoreAttribute : Attribute
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x000044CC File Offset: 0x000026CC
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoreAttribute()
		{
			Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "IgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr);
			IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, "<DoesNotContributeToSize>k__BackingField");
			IgnoreAttribute.NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, 100663355);
			IgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr, 100663356);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00004538 File Offset: 0x00002738
		public unsafe bool DoesNotContributeToSize
		{
			get
			{
				return this._DoesNotContributeToSize_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreAttribute.NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004578 File Offset: 0x00002778
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000267C File Offset: 0x0000087C
		public IgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000045B4 File Offset: 0x000027B4
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002685 File Offset: 0x00000885
		public unsafe bool _DoesNotContributeToSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoreAttribute.NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField)) = value;
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__DoesNotContributeToSize_k__BackingField;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_set_DoesNotContributeToSize_Public_set_Void_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
