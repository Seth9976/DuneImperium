using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020002DC RID: 732
	public class RemoteActivationAttribute : Attribute
	{
		// Token: 0x06002D8A RID: 11658 RVA: 0x000ECFE8 File Offset: 0x000EB1E8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteActivationAttribute()
		{
			Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "RemoteActivationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr);
			RemoteActivationAttribute.NativeFieldInfoPtr__contextProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr, "_contextProperties");
			RemoteActivationAttribute.NativeMethodInfoPtr__ctor_Public_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr, 100670602);
			RemoteActivationAttribute.NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr, 100670603);
			RemoteActivationAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr, 100670604);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000ED068 File Offset: 0x000EB268
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteActivationAttribute(IList contextProperties)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteActivationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contextProperties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteActivationAttribute.NativeMethodInfoPtr__ctor_Public_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000ED0B4 File Offset: 0x000EB2B4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsContextOK(Context ctx, IConstructionCallMessage ctor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteActivationAttribute.NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000ED114 File Offset: 0x000EB314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382071, XrefRangeEnd = 1382096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetPropertiesForNewContext(IConstructionCallMessage ctor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteActivationAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x0000F4EE File Offset: 0x0000D6EE
		public RemoteActivationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x000ED158 File Offset: 0x000EB358
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x0000F4F7 File Offset: 0x0000D6F7
		public unsafe IList _contextProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteActivationAttribute.NativeFieldInfoPtr__contextProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteActivationAttribute.NativeFieldInfoPtr__contextProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeFieldInfoPtr__contextProperties;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0;

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0;
	}
}
