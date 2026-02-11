using System;
using Canis.actions.serialized;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001E4 RID: 484
	public class SerializedSetObjective : SerializedAction
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x0006C504 File Offset: 0x0006A704
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSetObjective()
		{
			Il2CppClassPointerStore<SerializedSetObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSetObjective");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSetObjective>.NativeClassPtr);
			SerializedSetObjective.NativeFieldInfoPtr_Objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSetObjective>.NativeClassPtr, "Objective");
			SerializedSetObjective.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSetObjective>.NativeClassPtr, 100667809);
			SerializedSetObjective.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSetObjective>.NativeClassPtr, 100667810);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0006C570 File Offset: 0x0006A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589573, XrefRangeEnd = 589578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSetObjective.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0006C5CC File Offset: 0x0006A7CC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSetObjective()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSetObjective>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSetObjective.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00009FF1 File Offset: 0x000081F1
		public SerializedSetObjective(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0006C608 File Offset: 0x0006A808
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x00009FFA File Offset: 0x000081FA
		public unsafe Objective Objective
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSetObjective.NativeFieldInfoPtr_Objective);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Objective>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSetObjective.NativeFieldInfoPtr_Objective), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_Objective;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
