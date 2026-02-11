using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000253 RID: 595
	public class SerializedGainVictoryPoints : SerializedAction
	{
		// Token: 0x060019B4 RID: 6580 RVA: 0x000BCD68 File Offset: 0x000BAF68
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGainVictoryPoints()
		{
			Il2CppClassPointerStore<SerializedGainVictoryPoints>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedGainVictoryPoints");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGainVictoryPoints>.NativeClassPtr);
			SerializedGainVictoryPoints.NativeFieldInfoPtr_SourceAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGainVictoryPoints>.NativeClassPtr, "SourceAttributes");
			SerializedGainVictoryPoints.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainVictoryPoints>.NativeClassPtr, 100668011);
			SerializedGainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGainVictoryPoints>.NativeClassPtr, 100668012);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000BCDD4 File Offset: 0x000BAFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138138, XrefRangeEnd = 138147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGainVictoryPoints.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000BCE30 File Offset: 0x000BB030
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGainVictoryPoints()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGainVictoryPoints>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGainVictoryPoints.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0000B150 File Offset: 0x00009350
		public SerializedGainVictoryPoints(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x000BCE6C File Offset: 0x000BB06C
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0000B159 File Offset: 0x00009359
		public unsafe SerializableAttributes SourceAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainVictoryPoints.NativeFieldInfoPtr_SourceAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGainVictoryPoints.NativeFieldInfoPtr_SourceAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_SourceAttributes;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
