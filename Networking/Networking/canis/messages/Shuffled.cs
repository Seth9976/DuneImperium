using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000030 RID: 48
	public class Shuffled : GameMessage
	{
		// Token: 0x0600019E RID: 414 RVA: 0x0000A1C0 File Offset: 0x000083C0
		// Note: this type is marked as 'beforefieldinit'.
		static Shuffled()
		{
			Il2CppClassPointerStore<Shuffled>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "Shuffled");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shuffled>.NativeClassPtr);
			Shuffled.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shuffled>.NativeClassPtr, "EntityID");
			Shuffled.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shuffled>.NativeClassPtr, 100663379);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A218 File Offset: 0x00008418
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shuffled()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shuffled>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shuffled.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003199 File Offset: 0x00001399
		public Shuffled(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000A254 File Offset: 0x00008454
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000031A2 File Offset: 0x000013A2
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shuffled.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shuffled.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
