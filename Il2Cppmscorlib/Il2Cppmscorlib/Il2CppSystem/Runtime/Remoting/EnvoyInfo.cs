using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000292 RID: 658
	[Serializable]
	public class EnvoyInfo : Object
	{
		// Token: 0x06002A2B RID: 10795 RVA: 0x000E0970 File Offset: 0x000DEB70
		// Note: this type is marked as 'beforefieldinit'.
		static EnvoyInfo()
		{
			Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "EnvoyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr);
			EnvoyInfo.NativeFieldInfoPtr_envoySinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, "envoySinks");
			EnvoyInfo.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, 100670171);
			EnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, 100670172);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000E09DC File Offset: 0x000DEBDC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvoyInfo(IMessageSink sinks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyInfo.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000E0A28 File Offset: 0x000DEC28
		public unsafe virtual IMessageSink EnvoySinks
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
		public EnvoyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000E0A68 File Offset: 0x000DEC68
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x0000DFEF File Offset: 0x0000C1EF
		public unsafe IMessageSink envoySinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvoyInfo.NativeFieldInfoPtr_envoySinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvoyInfo.NativeFieldInfoPtr_envoySinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeFieldInfoPtr_envoySinks;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0;
	}
}
