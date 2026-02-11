using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200030B RID: 779
	public class RemotingSurrogateSelector : Object
	{
		// Token: 0x0600300B RID: 12299 RVA: 0x000F5FCC File Offset: 0x000F41CC
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingSurrogateSelector()
		{
			Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "RemotingSurrogateSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr);
			RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "s_cachedTypeObjRef");
			RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_objRefSurrogate");
			RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_objRemotingSurrogate");
			RemotingSurrogateSelector.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_next");
			RemotingSurrogateSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, 100670903);
			RemotingSurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, 100670904);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000F6074 File Offset: 0x000F4274
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingSurrogateSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingSurrogateSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000F60B0 File Offset: 0x000F42B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384236, XrefRangeEnd = 1384243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingSurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ssout = ((intPtr4 == 0) ? null : new ISurrogateSelector(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr5) : null;
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000106BA File Offset: 0x0000E8BA
		public RemotingSurrogateSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x000F6148 File Offset: 0x000F4348
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x000106C3 File Offset: 0x0000E8C3
		public unsafe static Type s_cachedTypeObjRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x000F6170 File Offset: 0x000F4370
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x000106D5 File Offset: 0x0000E8D5
		public unsafe static ObjRefSurrogate _objRefSurrogate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRefSurrogate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x000F6198 File Offset: 0x000F4398
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x000106E7 File Offset: 0x0000E8E7
		public unsafe static RemotingSurrogate _objRemotingSurrogate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemotingSurrogate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06003015 RID: 12309 RVA: 0x000F61C0 File Offset: 0x000F43C0
		// (set) Token: 0x06003016 RID: 12310 RVA: 0x000106F9 File Offset: 0x0000E8F9
		public unsafe ISurrogateSelector _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingSurrogateSelector.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingSurrogateSelector.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedTypeObjRef;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeFieldInfoPtr__objRefSurrogate;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeFieldInfoPtr__objRemotingSurrogate;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0;
	}
}
