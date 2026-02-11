using System;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000058 RID: 88
	public abstract class PropertyVisitor
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00003003 File Offset: 0x00001203
		public void AddAdapter(IPropertyVisitorAdapter adapter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00003010 File Offset: 0x00001210
		public void RemoveAdapter(IPropertyVisitorAdapter adapter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000301D File Offset: 0x0000121D
		public void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000302A File Offset: 0x0000122A
		public void Unity.Properties.IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00003037 File Offset: 0x00001237
		public void ContinueVisitation<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00003044 File Offset: 0x00001244
		public void Unity.Properties.ICollectionPropertyVisitor.Visit<TContainer, TCollection, TElement>(Property<TContainer, TCollection> property, ref TContainer container, ref TCollection collection) where TCollection : ICollection<TElement>
		{
			this.VisitCollection<TContainer, TCollection, TElement>(property, ref container, ref collection);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00003051 File Offset: 0x00001251
		public void Unity.Properties.IListPropertyVisitor.Visit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list) where TList : IList<TElement>
		{
			this.VisitList<TContainer, TList, TElement>(property, ref container, ref list);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000305E File Offset: 0x0000125E
		public void Unity.Properties.ISetPropertyVisitor.Visit<TContainer, TSet, TElement>(Property<TContainer, TSet> property, ref TContainer container, ref TSet set)
		{
			this.VisitSet<TContainer, TSet, TElement>(property, ref container, ref set);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000306B File Offset: 0x0000126B
		public void Unity.Properties.IDictionaryPropertyVisitor.Visit<TContainer, TDictionary, TKey, TValue>(Property<TContainer, TDictionary> property, ref TContainer container, ref TDictionary dictionary) where TDictionary : IDictionary<TKey, TValue>
		{
			this.VisitDictionary<TContainer, TDictionary, TKey, TValue>(property, ref container, ref dictionary);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008428 File Offset: 0x00006628
		public virtual bool IsExcluded<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
			return false;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000843C File Offset: 0x0000663C
		public virtual void VisitProperty<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
			PropertyContainer.TryAccept<TValue>(this, ref value, default(VisitParameters));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003078 File Offset: 0x00001278
		public virtual void VisitCollection<TContainer, TCollection, TElement>(Property<TContainer, TCollection> property, ref TContainer container, ref TCollection value) where TCollection : ICollection<TElement>
		{
			this.VisitProperty<TContainer, TCollection>(property, ref container, ref value);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003085 File Offset: 0x00001285
		public virtual void VisitList<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList value) where TList : IList<TElement>
		{
			this.VisitCollection<TContainer, TList, TElement>(property, ref container, ref value);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003092 File Offset: 0x00001292
		public virtual void VisitSet<TContainer, TSet, TValue>(Property<TContainer, TSet> property, ref TContainer container, ref TSet value)
		{
			this.VisitCollection<TContainer, TSet, TValue>(property, ref container, ref value);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000309F File Offset: 0x0000129F
		public virtual void VisitDictionary<TContainer, TDictionary, TKey, TValue>(Property<TContainer, TDictionary> property, ref TContainer container, ref TDictionary value) where TDictionary : IDictionary<TKey, TValue>
		{
			this.VisitCollection<TContainer, TDictionary, KeyValuePair<TKey, TValue>>(property, ref container, ref value);
		}
	}
}
