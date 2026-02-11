using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.canis.actions
{
	// Token: 0x02000223 RID: 547
	public class SerializedAcquire : SerializedAction
	{
		// Token: 0x06001827 RID: 6183 RVA: 0x000B6C74 File Offset: 0x000B4E74
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAcquire()
		{
			Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAcquire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr);
			SerializedAcquire.NativeFieldInfoPtr_ToArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr, "ToArea");
			SerializedAcquire.NativeFieldInfoPtr_SequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr, "SequenceName");
			SerializedAcquire.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr, 100667411);
			SerializedAcquire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr, 100667412);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000B6CF4 File Offset: 0x000B4EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131619, XrefRangeEnd = 131624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAcquire.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000B6D50 File Offset: 0x000B4F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131624, XrefRangeEnd = 131625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAcquire()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAcquire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAcquire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0000A7BC File Offset: 0x000089BC
		public SerializedAcquire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x000B6D8C File Offset: 0x000B4F8C
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x0000A7C5 File Offset: 0x000089C5
		public unsafe CardToAreas ToArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAcquire.NativeFieldInfoPtr_ToArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAcquire.NativeFieldInfoPtr_ToArea)) = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public unsafe string SequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAcquire.NativeFieldInfoPtr_SequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAcquire.NativeFieldInfoPtr_SequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_ToArea;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_SequenceName;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
