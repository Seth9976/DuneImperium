using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	public class GUITargetAttribute : Attribute
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x0000F90C File Offset: 0x0000DB0C
		// Note: this type is marked as 'beforefieldinit'.
		static GUITargetAttribute()
		{
			Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUITargetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr);
			GUITargetAttribute.NativeFieldInfoPtr_displayMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, "displayMask");
			GUITargetAttribute.NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, 100663555);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000F964 File Offset: 0x0000DB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187284, XrefRangeEnd = 1187298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGUITargetAttrValue(Type klass, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUITargetAttribute.NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003D4F File Offset: 0x00001F4F
		public GUITargetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003D58 File Offset: 0x00001F58
		public unsafe int displayMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUITargetAttribute.NativeFieldInfoPtr_displayMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUITargetAttribute.NativeFieldInfoPtr_displayMask)) = value;
			}
		}

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_displayMask;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0;
	}
}
