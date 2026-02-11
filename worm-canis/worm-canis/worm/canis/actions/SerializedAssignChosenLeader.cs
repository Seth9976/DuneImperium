using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x0200022B RID: 555
	public class SerializedAssignChosenLeader : SerializedAssignLeader
	{
		// Token: 0x06001872 RID: 6258 RVA: 0x000B8010 File Offset: 0x000B6210
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAssignChosenLeader()
		{
			Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAssignChosenLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr);
			SerializedAssignChosenLeader.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr, "Options");
			SerializedAssignChosenLeader.NativeFieldInfoPtr_AssignmentMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr, "AssignmentMethod");
			SerializedAssignChosenLeader.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr, 100667492);
			SerializedAssignChosenLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr, 100667493);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000B8090 File Offset: 0x000B6290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132147, XrefRangeEnd = 132154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAssignChosenLeader.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000B80EC File Offset: 0x000B62EC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAssignChosenLeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAssignChosenLeader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAssignChosenLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000A955 File Offset: 0x00008B55
		public SerializedAssignChosenLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000B8128 File Offset: 0x000B6328
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000A95E File Offset: 0x00008B5E
		public unsafe List<ArchetypeID> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignChosenLeader.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignChosenLeader.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x000B8158 File Offset: 0x000B6358
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000A97D File Offset: 0x00008B7D
		public unsafe string AssignmentMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignChosenLeader.NativeFieldInfoPtr_AssignmentMethod);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignChosenLeader.NativeFieldInfoPtr_AssignmentMethod), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_AssignmentMethod;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
