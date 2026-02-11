using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200012A RID: 298
	public sealed class ArraySliceDebugView<T> : Object where T : new()
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x0006CF70 File Offset: 0x0006B170
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySliceDebugView()
		{
			Il2CppClassPointerStore<ArraySliceDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "ArraySliceDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySliceDebugView<T>>.NativeClassPtr);
			ArraySliceDebugView<T>.NativeFieldInfoPtr_m_Slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySliceDebugView<T>>.NativeClassPtr, "m_Slice");
			ArraySliceDebugView<T>.NativeMethodInfoPtr__ctor_Public_Void_ArraySlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceDebugView<T>>.NativeClassPtr, 100666356);
			ArraySliceDebugView<T>.NativeMethodInfoPtr_get_Items_Public_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySliceDebugView<T>>.NativeClassPtr, 100666357);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0006D018 File Offset: 0x0006B218
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 629072, RefRangeEnd = 629078, XrefRangeStart = 629071, XrefRangeEnd = 629072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySliceDebugView(ArraySlice<T> slice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySliceDebugView<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(slice));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceDebugView<T>.NativeMethodInfoPtr__ctor_Public_Void_ArraySlice_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0006D068 File Offset: 0x0006B268
		public unsafe Il2CppArrayBase<T> Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySliceDebugView<T>.NativeMethodInfoPtr_get_Items_Public_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0000EB26 File Offset: 0x0000CD26
		public ArraySliceDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0006D0A0 File Offset: 0x0006B2A0
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0000EB2F File Offset: 0x0000CD2F
		public ArraySlice<T> m_Slice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceDebugView<T>.NativeFieldInfoPtr_m_Slice);
				return new ArraySlice<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArraySlice<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySliceDebugView<T>.NativeFieldInfoPtr_m_Slice), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArraySlice<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_m_Slice;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArraySlice_1_T_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_Il2CppArrayBase_1_T_0;
	}
}
