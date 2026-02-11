using System;
using Canis.messages.effect;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x0200001B RID: 27
	public class CameraMoved : EffectMessage
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00008314 File Offset: 0x00006514
		// Note: this type is marked as 'beforefieldinit'.
		static CameraMoved()
		{
			Il2CppClassPointerStore<CameraMoved>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "CameraMoved");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr);
			CameraMoved.NativeFieldInfoPtr_LocationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr, "LocationID");
			CameraMoved.NativeFieldInfoPtr_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr, "Flavor");
			CameraMoved.NativeFieldInfoPtr_RecordPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr, "RecordPosition");
			CameraMoved.NativeFieldInfoPtr_SuppressForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr, "SuppressForPlayer");
			CameraMoved.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr, 100663341);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000083A8 File Offset: 0x000065A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraMoved()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMoved>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraMoved.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000028DF File Offset: 0x00000ADF
		public CameraMoved(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000083E4 File Offset: 0x000065E4
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000028E8 File Offset: 0x00000AE8
		public unsafe EntityID LocationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_LocationID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_LocationID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00008414 File Offset: 0x00006614
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002907 File Offset: 0x00000B07
		public unsafe string Flavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_Flavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_Flavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000843C File Offset: 0x0000663C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002926 File Offset: 0x00000B26
		public unsafe bool RecordPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_RecordPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_RecordPosition)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00008464 File Offset: 0x00006664
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002941 File Offset: 0x00000B41
		public unsafe AccountID SuppressForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_SuppressForPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraMoved.NativeFieldInfoPtr_SuppressForPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_LocationID;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_Flavor;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_RecordPosition;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_SuppressForPlayer;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
