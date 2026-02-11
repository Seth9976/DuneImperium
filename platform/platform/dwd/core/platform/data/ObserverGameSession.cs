using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.data
{
	// Token: 0x0200004F RID: 79
	public class ObserverGameSession : Object
	{
		// Token: 0x0600032B RID: 811 RVA: 0x0000FD70 File Offset: 0x0000DF70
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverGameSession()
		{
			Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.data", "ObserverGameSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr);
			ObserverGameSession.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, "ID");
			ObserverGameSession.NativeFieldInfoPtr_DnsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, "DnsName");
			ObserverGameSession.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, "Port");
			ObserverGameSession.NativeFieldInfoPtr_XboxOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, "XboxOnly");
			ObserverGameSession.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, 100663797);
			ObserverGameSession.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, 100663798);
			ObserverGameSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr, 100663799);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000FE2C File Offset: 0x0000E02C
		public unsafe GameID GameID
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1169878, RefRangeEnd = 1169884, XrefRangeStart = 1169874, XrefRangeEnd = 1169878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverGameSession.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000FE6C File Offset: 0x0000E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169884, XrefRangeEnd = 1169908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverGameSession.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverGameSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverGameSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverGameSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000378A File Offset: 0x0000198A
		public ObserverGameSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00003793 File Offset: 0x00001993
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000FF14 File Offset: 0x0000E114
		// (set) Token: 0x06000333 RID: 819 RVA: 0x000037B2 File Offset: 0x000019B2
		public unsafe string DnsName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_DnsName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_DnsName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000FF3C File Offset: 0x0000E13C
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000037D1 File Offset: 0x000019D1
		public unsafe int Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_Port)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000FF64 File Offset: 0x0000E164
		// (set) Token: 0x06000337 RID: 823 RVA: 0x000037EC File Offset: 0x000019EC
		public unsafe bool XboxOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_XboxOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverGameSession.NativeFieldInfoPtr_XboxOnly)) = value;
			}
		}

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_DnsName;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_Port;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_XboxOnly;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
