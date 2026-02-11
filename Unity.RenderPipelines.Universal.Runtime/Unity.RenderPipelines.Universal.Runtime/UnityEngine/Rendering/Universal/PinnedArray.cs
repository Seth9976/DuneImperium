using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200008A RID: 138
	public sealed class PinnedArray<T> : ValueType where T : new()
	{
		// Token: 0x06000C67 RID: 3175 RVA: 0x00041338 File Offset: 0x0003F538
		// Note: this type is marked as 'beforefieldinit'.
		static PinnedArray()
		{
			Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PinnedArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr);
			PinnedArray<T>.NativeFieldInfoPtr_managedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr, "managedArray");
			PinnedArray<T>.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr, "handle");
			PinnedArray<T>.NativeFieldInfoPtr_nativeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr, "nativeArray");
			PinnedArray<T>.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr, 100664988);
			PinnedArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr, 100664989);
			PinnedArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr, 100664990);
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0004141C File Offset: 0x0003F61C
		public unsafe int length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedArray<T>.NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00041460 File Offset: 0x0003F660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611820, XrefRangeEnd = 611829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PinnedArray(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000414AC File Offset: 0x0003F6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611829, XrefRangeEnd = 611830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000797D File Offset: 0x00005B7D
		public PinnedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00007986 File Offset: 0x00005B86
		public PinnedArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinnedArray<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000414E4 File Offset: 0x0003F6E4
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00007998 File Offset: 0x00005B98
		public unsafe Il2CppArrayBase<T> managedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedArray<T>.NativeFieldInfoPtr_managedArray);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedArray<T>.NativeFieldInfoPtr_managedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0004150C File Offset: 0x0003F70C
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000079B7 File Offset: 0x00005BB7
		public unsafe GCHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedArray<T>.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedArray<T>.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00041534 File Offset: 0x0003F734
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000079D2 File Offset: 0x00005BD2
		public NativeArray<T> nativeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedArray<T>.NativeFieldInfoPtr_nativeArray);
				return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedArray<T>.NativeFieldInfoPtr_nativeArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_managedArray;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_nativeArray;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
