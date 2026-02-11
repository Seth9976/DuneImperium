using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200026A RID: 618
	public class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<Color>
	{
		// Token: 0x06002DD9 RID: 11737 RVA: 0x000C3E9C File Offset: 0x000C209C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderInfoStorageRGBAFloat()
		{
			Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "ShaderInfoStorageRGBAFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat>.NativeClassPtr);
			ShaderInfoStorageRGBAFloat.NativeFieldInfoPtr_s_Convert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat>.NativeClassPtr, "s_Convert");
			ShaderInfoStorageRGBAFloat.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat>.NativeClassPtr, 100669989);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000C3EF4 File Offset: 0x000C20F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351676, XrefRangeEnd = 351683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderInfoStorageRGBAFloat(int initialSize = 64, int maxSize = 4096)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorageRGBAFloat.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00012D59 File Offset: 0x00010F59
		public ShaderInfoStorageRGBAFloat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000C3F4C File Offset: 0x000C214C
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00012D62 File Offset: 0x00010F62
		public unsafe static Func<Color, Color> s_Convert
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderInfoStorageRGBAFloat.NativeFieldInfoPtr_s_Convert, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderInfoStorageRGBAFloat.NativeFieldInfoPtr_s_Convert, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr_s_Convert;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x02000559 RID: 1369
		[ObfuscatedName("UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060041D5 RID: 16853 RVA: 0x00103450 File Offset: 0x00101650
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat.__c>.NativeClassPtr);
				ShaderInfoStorageRGBAFloat.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat.__c>.NativeClassPtr, "<>9");
				ShaderInfoStorageRGBAFloat.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat.__c>.NativeClassPtr, 100669992);
				ShaderInfoStorageRGBAFloat.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat.__c>.NativeClassPtr, 100669993);
			}

			// Token: 0x060041D6 RID: 16854 RVA: 0x001034B8 File Offset: 0x001016B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderInfoStorageRGBAFloat.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorageRGBAFloat.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041D7 RID: 16855 RVA: 0x001034F4 File Offset: 0x001016F4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 351672, RefRangeEnd = 351676, XrefRangeStart = 351672, XrefRangeEnd = 351672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color __cctor_b__2_0(Color c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderInfoStorageRGBAFloat.__c.NativeMethodInfoPtr___cctor_b__2_0_Internal_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060041D8 RID: 16856 RVA: 0x0001BFEB File Offset: 0x0001A1EB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013BC RID: 5052
			// (get) Token: 0x060041D9 RID: 16857 RVA: 0x00103540 File Offset: 0x00101740
			// (set) Token: 0x060041DA RID: 16858 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
			public unsafe static ShaderInfoStorageRGBAFloat.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderInfoStorageRGBAFloat.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShaderInfoStorageRGBAFloat.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderInfoStorageRGBAFloat.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E32 RID: 11826
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E33 RID: 11827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E34 RID: 11828
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__2_0_Internal_Color_Color_0;
		}

		// Token: 0x0200055A RID: 1370
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
