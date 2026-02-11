using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public sealed class GUILayoutOption : Object
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0000AE64 File Offset: 0x00009064
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutOption()
		{
			Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr);
			GUILayoutOption.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, "type");
			GUILayoutOption.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, "value");
			GUILayoutOption.NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, 100663428);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000AED0 File Offset: 0x000090D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutOption(GUILayoutOption.Type type, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutOption.NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003082 File Offset: 0x00001282
		public GUILayoutOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000AF2C File Offset: 0x0000912C
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000308B File Offset: 0x0000128B
		public unsafe GUILayoutOption.Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000AF54 File Offset: 0x00009154
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000030A6 File Offset: 0x000012A6
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0;

		// Token: 0x0200006F RID: 111
		public enum Type
		{
			// Token: 0x0400039C RID: 924
			fixedWidth,
			// Token: 0x0400039D RID: 925
			fixedHeight,
			// Token: 0x0400039E RID: 926
			minWidth,
			// Token: 0x0400039F RID: 927
			maxWidth,
			// Token: 0x040003A0 RID: 928
			minHeight,
			// Token: 0x040003A1 RID: 929
			maxHeight,
			// Token: 0x040003A2 RID: 930
			stretchWidth,
			// Token: 0x040003A3 RID: 931
			stretchHeight,
			// Token: 0x040003A4 RID: 932
			alignStart,
			// Token: 0x040003A5 RID: 933
			alignMiddle,
			// Token: 0x040003A6 RID: 934
			alignEnd,
			// Token: 0x040003A7 RID: 935
			alignJustify,
			// Token: 0x040003A8 RID: 936
			equalSize,
			// Token: 0x040003A9 RID: 937
			spacing
		}
	}
}
