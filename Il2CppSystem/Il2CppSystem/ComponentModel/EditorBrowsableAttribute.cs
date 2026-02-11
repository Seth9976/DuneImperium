using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000E2 RID: 226
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x06000F14 RID: 3860 RVA: 0x00055088 File Offset: 0x00053288
		// Note: this type is marked as 'beforefieldinit'.
		static EditorBrowsableAttribute()
		{
			Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EditorBrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr);
			EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, "browsableState");
			EditorBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100665485);
			EditorBrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100665486);
			EditorBrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100665487);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00055108 File Offset: 0x00053308
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorBrowsableAttribute(EditorBrowsableState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00055150 File Offset: 0x00053350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456154, XrefRangeEnd = 456156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000551A0 File Offset: 0x000533A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0000771D File Offset: 0x0000591D
		public EditorBrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x000551DC File Offset: 0x000533DC
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00007726 File Offset: 0x00005926
		public unsafe EditorBrowsableState browsableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState)) = value;
			}
		}

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr_browsableState;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
