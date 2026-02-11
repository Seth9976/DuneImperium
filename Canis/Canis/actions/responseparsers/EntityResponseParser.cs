using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetresponse;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000214 RID: 532
	[Serializable]
	public class EntityResponseParser : ResponseParser<Entity>
	{
		// Token: 0x06001661 RID: 5729 RVA: 0x00073394 File Offset: 0x00071594
		// Note: this type is marked as 'beforefieldinit'.
		static EntityResponseParser()
		{
			Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "EntityResponseParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr);
			EntityResponseParser.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr, "Instance");
			EntityResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_Entity_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr, 100668390);
			EntityResponseParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr, 100668391);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00073400 File Offset: 0x00071600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593427, XrefRangeEnd = 593453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Entity> ParseResponse(Match match, Object responseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_Entity_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00073470 File Offset: 0x00071670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593453, XrefRangeEnd = 593456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityResponseParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityResponseParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0000AC30 File Offset: 0x00008E30
		public EntityResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x000734AC File Offset: 0x000716AC
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x0000AC39 File Offset: 0x00008E39
		public unsafe static EntityResponseParser Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityResponseParser.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityResponseParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityResponseParser.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_Entity_Match_Object_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200045E RID: 1118
		[ObfuscatedName("Canis.actions.responseparsers.EntityResponseParser+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x060031F0 RID: 12784 RVA: 0x000CDD90 File Offset: 0x000CBF90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityResponseParser>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr);
				EntityResponseParser.__c__DisplayClass1_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr, "match");
				EntityResponseParser.__c__DisplayClass1_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr, "<>9__1");
				EntityResponseParser.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr, 100668393);
				EntityResponseParser.__c__DisplayClass1_0.NativeMethodInfoPtr__ParseResponse_b__0_Internal_IEnumerable_1_Entity_EntityListTargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr, 100668394);
				EntityResponseParser.__c__DisplayClass1_0.NativeMethodInfoPtr__ParseResponse_b__1_Internal_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr, 100668395);
			}

			// Token: 0x060031F1 RID: 12785 RVA: 0x000CDE20 File Offset: 0x000CC020
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityResponseParser.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityResponseParser.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031F2 RID: 12786 RVA: 0x000CDE5C File Offset: 0x000CC05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593406, XrefRangeEnd = 593417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _ParseResponse_b__0(EntityListTargetResponse eltr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(eltr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityResponseParser.__c__DisplayClass1_0.NativeMethodInfoPtr__ParseResponse_b__0_Internal_IEnumerable_1_Entity_EntityListTargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060031F3 RID: 12787 RVA: 0x000CDEAC File Offset: 0x000CC0AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593417, XrefRangeEnd = 593427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _ParseResponse_b__1(EntityID entID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityResponseParser.__c__DisplayClass1_0.NativeMethodInfoPtr__ParseResponse_b__1_Internal_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060031F4 RID: 12788 RVA: 0x00017EA5 File Offset: 0x000160A5
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D31 RID: 3377
			// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000CDEFC File Offset: 0x000CC0FC
			// (set) Token: 0x060031F6 RID: 12790 RVA: 0x00017EAE File Offset: 0x000160AE
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityResponseParser.__c__DisplayClass1_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityResponseParser.__c__DisplayClass1_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000CDF2C File Offset: 0x000CC12C
			// (set) Token: 0x060031F8 RID: 12792 RVA: 0x00017ECD File Offset: 0x000160CD
			public unsafe Func<EntityID, IEnumerable<Entity>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityResponseParser.__c__DisplayClass1_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityID, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityResponseParser.__c__DisplayClass1_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F3F RID: 7999
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F40 RID: 8000
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001F41 RID: 8001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F42 RID: 8002
			private static readonly IntPtr NativeMethodInfoPtr__ParseResponse_b__0_Internal_IEnumerable_1_Entity_EntityListTargetResponse_0;

			// Token: 0x04001F43 RID: 8003
			private static readonly IntPtr NativeMethodInfoPtr__ParseResponse_b__1_Internal_IEnumerable_1_Entity_EntityID_0;
		}
	}
}
