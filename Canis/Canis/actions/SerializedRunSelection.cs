using System;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public class SerializedRunSelection : SerializedAction
	{
		// Token: 0x060013BC RID: 5052 RVA: 0x00069350 File Offset: 0x00067550
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunSelection()
		{
			Il2CppClassPointerStore<SerializedRunSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedRunSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunSelection>.NativeClassPtr);
			SerializedRunSelection.NativeFieldInfoPtr_SelectedEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunSelection>.NativeClassPtr, "SelectedEntityID");
			SerializedRunSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunSelection>.NativeClassPtr, 100667609);
			SerializedRunSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunSelection>.NativeClassPtr, 100667610);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000693BC File Offset: 0x000675BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunSelection.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00069418 File Offset: 0x00067618
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000099A8 File Offset: 0x00007BA8
		public SerializedRunSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00069454 File Offset: 0x00067654
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x000099B1 File Offset: 0x00007BB1
		public unsafe EntityID SelectedEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunSelection.NativeFieldInfoPtr_SelectedEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunSelection.NativeFieldInfoPtr_SelectedEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_SelectedEntityID;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
