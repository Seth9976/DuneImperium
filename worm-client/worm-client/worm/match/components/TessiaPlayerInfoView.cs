using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001C4 RID: 452
	public class TessiaPlayerInfoView : ObserveOnce
	{
		// Token: 0x060013D0 RID: 5072 RVA: 0x00054570 File Offset: 0x00052770
		// Note: this type is marked as 'beforefieldinit'.
		static TessiaPlayerInfoView()
		{
			Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "TessiaPlayerInfoView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr);
			TessiaPlayerInfoView.NativeFieldInfoPtr_tokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr, "tokens");
			TessiaPlayerInfoView.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr, 100666018);
			TessiaPlayerInfoView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr, 100666019);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000545DC File Offset: 0x000527DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713391, XrefRangeEnd = 713428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TessiaPlayerInfoView.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00054624 File Offset: 0x00052824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713428, XrefRangeEnd = 713433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TessiaPlayerInfoView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessiaPlayerInfoView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0000C2BF File Offset: 0x0000A4BF
		public TessiaPlayerInfoView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00054660 File Offset: 0x00052860
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		public unsafe Il2CppReferenceArray<GameObject> tokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TessiaPlayerInfoView.NativeFieldInfoPtr_tokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TessiaPlayerInfoView.NativeFieldInfoPtr_tokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_tokens;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CD RID: 973
		[ObfuscatedName("worm.match.components.TessiaPlayerInfoView+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002767 RID: 10087 RVA: 0x0008FAD0 File Offset: 0x0008DCD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TessiaPlayerInfoView>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr);
				TessiaPlayerInfoView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr, "<>9");
				TessiaPlayerInfoView.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr, "<>9__1_0");
				TessiaPlayerInfoView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr, 100666021);
				TessiaPlayerInfoView.__c.NativeMethodInfoPtr__Initialize_b__1_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr, 100666022);
			}

			// Token: 0x06002768 RID: 10088 RVA: 0x0008FB4C File Offset: 0x0008DD4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TessiaPlayerInfoView.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessiaPlayerInfoView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002769 RID: 10089 RVA: 0x0008FB88 File Offset: 0x0008DD88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713384, XrefRangeEnd = 713391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__1_0(EntityComponent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessiaPlayerInfoView.__c.NativeMethodInfoPtr__Initialize_b__1_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600276A RID: 10090 RVA: 0x00015AAE File Offset: 0x00013CAE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x0600276B RID: 10091 RVA: 0x0008FBD8 File Offset: 0x0008DDD8
			// (set) Token: 0x0600276C RID: 10092 RVA: 0x00015AB7 File Offset: 0x00013CB7
			public unsafe static TessiaPlayerInfoView.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TessiaPlayerInfoView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TessiaPlayerInfoView.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TessiaPlayerInfoView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x0600276D RID: 10093 RVA: 0x0008FC00 File Offset: 0x0008DE00
			// (set) Token: 0x0600276E RID: 10094 RVA: 0x00015AC9 File Offset: 0x00013CC9
			public unsafe static Func<EntityComponent, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TessiaPlayerInfoView.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TessiaPlayerInfoView.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__1_0_Internal_Boolean_EntityComponent_0;
		}
	}
}
