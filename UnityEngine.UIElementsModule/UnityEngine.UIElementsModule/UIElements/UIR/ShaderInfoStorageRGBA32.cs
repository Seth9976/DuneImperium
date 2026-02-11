using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000269 RID: 617
	public class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32>
	{
		// Token: 0x06002DD4 RID: 11732 RVA: 0x000C3DC4 File Offset: 0x000C1FC4
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderInfoStorageRGBA32()
		{
			Il2CppClassPointerStore<ShaderInfoStorageRGBA32>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "ShaderInfoStorageRGBA32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInfoStorageRGBA32>.NativeClassPtr);
			ShaderInfoStorageRGBA32.NativeFieldInfoPtr_s_Convert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorageRGBA32>.NativeClassPtr, "s_Convert");
			ShaderInfoStorageRGBA32.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorageRGBA32>.NativeClassPtr, 100669984);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000C3E1C File Offset: 0x000C201C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351665, XrefRangeEnd = 351672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderInfoStorageRGBA32(int initialSize = 64, int maxSize = 4096)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderInfoStorageRGBA32>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorageRGBA32.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00012D3E File Offset: 0x00010F3E
		public ShaderInfoStorageRGBA32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000C3E74 File Offset: 0x000C2074
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x00012D47 File Offset: 0x00010F47
		public unsafe static Func<Color, Color32> s_Convert
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderInfoStorageRGBA32.NativeFieldInfoPtr_s_Convert, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Color, Color32>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderInfoStorageRGBA32.NativeFieldInfoPtr_s_Convert, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_s_Convert;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x02000557 RID: 1367
		[ObfuscatedName("UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060041CF RID: 16847 RVA: 0x00103338 File Offset: 0x00101538
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShaderInfoStorageRGBA32.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderInfoStorageRGBA32>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInfoStorageRGBA32.__c>.NativeClassPtr);
				ShaderInfoStorageRGBA32.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorageRGBA32.__c>.NativeClassPtr, "<>9");
				ShaderInfoStorageRGBA32.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorageRGBA32.__c>.NativeClassPtr, 100669987);
				ShaderInfoStorageRGBA32.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_Color32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorageRGBA32.__c>.NativeClassPtr, 100669988);
			}

			// Token: 0x060041D0 RID: 16848 RVA: 0x001033A0 File Offset: 0x001015A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderInfoStorageRGBA32.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorageRGBA32.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041D1 RID: 16849 RVA: 0x001033DC File Offset: 0x001015DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351664, XrefRangeEnd = 351665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color32 __cctor_b__2_0(Color c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorageRGBA32.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_Color32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060041D2 RID: 16850 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013BB RID: 5051
			// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00103428 File Offset: 0x00101628
			// (set) Token: 0x060041D4 RID: 16852 RVA: 0x0001BFD9 File Offset: 0x0001A1D9
			public unsafe static ShaderInfoStorageRGBA32.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderInfoStorageRGBA32.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShaderInfoStorageRGBA32.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderInfoStorageRGBA32.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E2F RID: 11823
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E30 RID: 11824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E31 RID: 11825
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__2_0_Internal_Color32_Color_0;
		}

		// Token: 0x02000558 RID: 1368
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
