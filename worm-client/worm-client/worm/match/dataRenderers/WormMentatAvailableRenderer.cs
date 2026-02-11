using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000146 RID: 326
	public class WormMentatAvailableRenderer : Observer
	{
		// Token: 0x06000EB2 RID: 3762 RVA: 0x00044568 File Offset: 0x00042768
		// Note: this type is marked as 'beforefieldinit'.
		static WormMentatAvailableRenderer()
		{
			Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormMentatAvailableRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr);
			WormMentatAvailableRenderer.NativeFieldInfoPtr_present = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr, "present");
			WormMentatAvailableRenderer.NativeFieldInfoPtr_taken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr, "taken");
			WormMentatAvailableRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr, 100665277);
			WormMentatAvailableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr, 100665278);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000445E8 File Offset: 0x000427E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706950, XrefRangeEnd = 706976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMentatAvailableRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00044624 File Offset: 0x00042824
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMentatAvailableRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatAvailableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00009BFC File Offset: 0x00007DFC
		public WormMentatAvailableRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00044660 File Offset: 0x00042860
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00009C05 File Offset: 0x00007E05
		public unsafe GameObject present
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatAvailableRenderer.NativeFieldInfoPtr_present);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatAvailableRenderer.NativeFieldInfoPtr_present), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00044690 File Offset: 0x00042890
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00009C24 File Offset: 0x00007E24
		public unsafe GameObject taken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatAvailableRenderer.NativeFieldInfoPtr_taken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMentatAvailableRenderer.NativeFieldInfoPtr_taken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr_present;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr_taken;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000393 RID: 915
		[ObfuscatedName("worm.match.dataRenderers.WormMentatAvailableRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060024CB RID: 9419 RVA: 0x000875AC File Offset: 0x000857AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMentatAvailableRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr);
				WormMentatAvailableRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr, "<>9");
				WormMentatAvailableRenderer.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr, "<>9__2_0");
				WormMentatAvailableRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr, 100665280);
				WormMentatAvailableRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr, 100665281);
			}

			// Token: 0x060024CC RID: 9420 RVA: 0x00087628 File Offset: 0x00085828
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMentatAvailableRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatAvailableRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024CD RID: 9421 RVA: 0x00087664 File Offset: 0x00085864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706940, XrefRangeEnd = 706950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__2_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMentatAvailableRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024CE RID: 9422 RVA: 0x0001484C File Offset: 0x00012A4C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x060024CF RID: 9423 RVA: 0x000876B4 File Offset: 0x000858B4
			// (set) Token: 0x060024D0 RID: 9424 RVA: 0x00014855 File Offset: 0x00012A55
			public unsafe static WormMentatAvailableRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMentatAvailableRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMentatAvailableRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMentatAvailableRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x060024D1 RID: 9425 RVA: 0x000876DC File Offset: 0x000858DC
			// (set) Token: 0x060024D2 RID: 9426 RVA: 0x00014867 File Offset: 0x00012A67
			public unsafe static Func<EntityComponent, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMentatAvailableRenderer.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMentatAvailableRenderer.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001520 RID: 5408
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001521 RID: 5409
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001522 RID: 5410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0;
		}
	}
}
