using System;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm
{
	// Token: 0x0200003B RID: 59
	public class FoldspaceTooltipSource : MonoBehaviour
	{
		// Token: 0x0600029F RID: 671 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		// Note: this type is marked as 'beforefieldinit'.
		static FoldspaceTooltipSource()
		{
			Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "FoldspaceTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr);
			FoldspaceTooltipSource.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr, "entities");
			FoldspaceTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr, 100663727);
			FoldspaceTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr, 100663728);
			FoldspaceTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr, 100663729);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00020F28 File Offset: 0x0001F128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690473, XrefRangeEnd = 690477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceTooltipSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00020F5C File Offset: 0x0001F15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690477, XrefRangeEnd = 690523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00020F94 File Offset: 0x0001F194
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoldspaceTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003377 File Offset: 0x00001577
		public FoldspaceTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003380 File Offset: 0x00001580
		public unsafe DBGEntitiesProvider entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoldspaceTooltipSource.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FoldspaceTooltipSource.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D8 RID: 728
		[ObfuscatedName("worm.FoldspaceTooltipSource+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001DB1 RID: 7601 RVA: 0x000732F0 File Offset: 0x000714F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FoldspaceTooltipSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr);
				FoldspaceTooltipSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr, "<>9");
				FoldspaceTooltipSource.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr, "<>9__2_0");
				FoldspaceTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr, 100663731);
				FoldspaceTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__2_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr, 100663732);
			}

			// Token: 0x06001DB2 RID: 7602 RVA: 0x0007336C File Offset: 0x0007156C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoldspaceTooltipSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB3 RID: 7603 RVA: 0x000733A8 File Offset: 0x000715A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690454, XrefRangeEnd = 690473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLocalizedTooltip_b__2_0(EntityComponent entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__2_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DB4 RID: 7604 RVA: 0x00010EFE File Offset: 0x0000F0FE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000733F8 File Offset: 0x000715F8
			// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00010F07 File Offset: 0x0000F107
			public unsafe static FoldspaceTooltipSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FoldspaceTooltipSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FoldspaceTooltipSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FoldspaceTooltipSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00073420 File Offset: 0x00071620
			// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00010F19 File Offset: 0x0000F119
			public unsafe static Func<EntityComponent, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FoldspaceTooltipSource.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FoldspaceTooltipSource.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400113B RID: 4411
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400113C RID: 4412
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400113D RID: 4413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400113E RID: 4414
			private static readonly IntPtr NativeMethodInfoPtr__GetLocalizedTooltip_b__2_0_Internal_Boolean_EntityComponent_0;
		}
	}
}
