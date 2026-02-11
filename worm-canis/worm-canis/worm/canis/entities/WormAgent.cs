using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.entities
{
	// Token: 0x02000022 RID: 34
	public class WormAgent : WormEntity
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00074898 File Offset: 0x00072A98
		// Note: this type is marked as 'beforefieldinit'.
		static WormAgent()
		{
			Il2CppClassPointerStore<WormAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgent>.NativeClassPtr);
			WormAgent.NativeMethodInfoPtr_get_IsMentat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgent>.NativeClassPtr, 100663933);
			WormAgent.NativeMethodInfoPtr__ctor_Private_Void_Match_PlayerEntity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgent>.NativeClassPtr, 100663934);
			WormAgent.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgent>.NativeClassPtr, 100663935);
			WormAgent.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgent>.NativeClassPtr, 100663936);
			WormAgent.NativeMethodInfoPtr_MakeMentat_Public_Static_WormAgent_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgent>.NativeClassPtr, 100663937);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0007492C File Offset: 0x00072B2C
		public unsafe bool IsMentat
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 34624, RefRangeEnd = 34635, XrefRangeStart = 34620, XrefRangeEnd = 34624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgent.NativeMethodInfoPtr_get_IsMentat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00074968 File Offset: 0x00072B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34666, RefRangeEnd = 34668, XrefRangeStart = 34635, XrefRangeEnd = 34666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgent(Match m, PlayerEntity owner, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgent.NativeMethodInfoPtr__ctor_Private_Void_Match_PlayerEntity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000749D8 File Offset: 0x00072BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34674, RefRangeEnd = 34676, XrefRangeStart = 34668, XrefRangeEnd = 34674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgent(Match m, PlayerEntity owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgent.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00074A38 File Offset: 0x00072C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34685, RefRangeEnd = 34687, XrefRangeStart = 34676, XrefRangeEnd = 34685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgent(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgent.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00074AA8 File Offset: 0x00072CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34696, RefRangeEnd = 34697, XrefRangeStart = 34687, XrefRangeEnd = 34696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormAgent MakeMentat(Match m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgent.NativeMethodInfoPtr_MakeMentat_Public_Static_WormAgent_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr3) : null;
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003511 File Offset: 0x00001711
		public WormAgent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMentat_Public_get_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Match_PlayerEntity_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_MakeMentat_Public_Static_WormAgent_Match_0;
	}
}
